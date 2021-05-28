using System;
using WindowsAPI.Interfaces;
using WindowsAPI.Enumerables;
using WindowsAPI.Classes;

namespace WindowsAPI
{
    class Program
    {
        static void Main()
        {
            string options = "Select options:\n";
            string option1 = "Battery";
            string option2 = "Time";

            options += $"1: { option1 }\n2: { option2 }\n";

            Console.WriteLine(options);

            switch (Console.ReadLine())
            {
                case "1":
                    var status = new BatteryStatus();

                    if (IUtil.GetBatteryStatus(ref status))
                    {
                        IUtil.MessageBox(new IntPtr(0), status.ToString(), option1, MessageBoxOptions.OkOnly);
                    }
                    break;
                case "2":
                    var time = new Time();
                    ITime.GetLocalTime(ref time);
                    //MySystemTime.FromDateTime(DateTime.Now.AddHours(2)); //Add two hours to the current time
                    IUtil.MessageBox(new IntPtr(0), time.ToString(), option2, MessageBoxOptions.OkOnly);
                    break;
                default:
                    Main();
                    break;
            }

            Console.ReadKey();
            Main();
        }
    }
}
