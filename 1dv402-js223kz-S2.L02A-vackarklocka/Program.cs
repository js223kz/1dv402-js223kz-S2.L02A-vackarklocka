using System;
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

             Console.WriteLine("Test 1");
             Console.WriteLine("Test av standardkonstruktorn");
        }

        private static void Run(AlarmClock alarm, int minutes)
        {
            //alarm.TickTock();
        }

        private static void ViewErrorMessage(string message)
        {
        }
    }
}
