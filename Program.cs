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
            string option1 = "Battery";
            string option2 = "Time";

            Console.WriteLine($"Select options:\n1: { option1 }\n2: { option2 }\n");

            switch (Console.ReadLine())
            {
                case "1":
                    var status = new BatteryStatus();

                    if (IUtil.GetBatteryStatus(ref status))
                        IUtil.MessageBox(new IntPtr(0), status.ToString(), option1, MessageBoxButton.OkOnly);
                    else
                        IUtil.MessageBox(new IntPtr(0), "No information", option1, MessageBoxButton.OkOnly);
                    break;
                case "2":
                    var time = new Time();
                    ITime.GetSystemTime(ref time);
                    IUtil.MessageBox(new IntPtr(0), time.ToString(), option2, MessageBoxButton.OkOnly);
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
