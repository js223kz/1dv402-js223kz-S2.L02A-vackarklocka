﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_js223kz_S2.L02A_vackarklocka
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarm = new AlarmClock();

            Console.WriteLine("Test 1\nTest av standardkonstruktorn");
            Console.WriteLine(alarm.ToString());

            alarm = new AlarmClock(9, 42);
            Console.WriteLine("\nTest 2\nTest av konstruktorn med två parametrar, (9, 42)");
            Console.WriteLine(alarm.ToString());
           
            alarm = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("\nTest 3\nTest av konstruktorn med fyra parametrar, (13, 24, 7, 35)");
            Console.WriteLine(alarm.ToString());

            alarm = new AlarmClock(23, 58, 7, 35);
            Console.WriteLine("\nTest 4\nStäller befintligt AlarmClock-Objekt till 23:58 och låter den gå 13 minuter.\n");
            Run(alarm, 13);

            alarm = new AlarmClock(6, 12, 6, 15);
            Console.WriteLine("\nTest 5\nStäller befintligt AlarmClock-Objekt till 6:12 och alarmtiden till 6:15 och låter den gå i 6 minuter.\n");
            Run(alarm, 6);
        }

        private static void Run(AlarmClock alarm, int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════╗ ");
            Console.WriteLine(" ║ Väckarklockan URLED (TM) ║ ");
            Console.WriteLine(" ║  Modellnr.: 1DV402S2L2A  ║ ");
            Console.WriteLine(" ╚══════════════════════════╝ ");
            Console.ResetColor();
            
            for (int i = 0; i < minutes; i++)
            {
                 alarm.TickTock();
                 Console.WriteLine(alarm.ToString());
                 
            }
            Console.WriteLine();
           
        }

        private static void ViewErrorMessage(string message)
        {
        }
    }
}
