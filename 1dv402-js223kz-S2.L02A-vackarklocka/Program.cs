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

            Console.WriteLine("\nTest 6\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas fel värden\n");
            string message = "";
            ViewErrorMessage(message);
 
            Console.WriteLine("\nTest 7\nTestar konstruktorer så att undantag kastas då tid och alarmtid tilldelas fel värden\n");
            ViewTestHeader(message);
        
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

            bool alarmTime = true;
            
            for (int i = 0; i < minutes; i++)
            {
                alarmTime = alarm.TickTock();

                if (alarmTime){
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(alarm.ToString() + " BEEP! BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }else{
                    Console.WriteLine(alarm.ToString());
                }   
            }
        }

        private static void ViewErrorMessage(string message)
        {
            
            AlarmClock testProperties = new AlarmClock();
            
             try{
                    testProperties.Hour = 36;
             }
             catch (ArgumentException e)
             {
                 Console.WriteLine(); 
                 DisplayExceptionMessage(e.Message);
             }
             
            try
             {
                 testProperties.Minute = 72;
             }
             catch (ArgumentException e)
             {
                 DisplayExceptionMessage(e.Message);
             }
             
            try
             {
                 testProperties.AlarmHour = 26;
             }
             catch (ArgumentException e)
             {
                 DisplayExceptionMessage(e.Message);
             }
             
            try
             {
                 testProperties.AlarmMinute = 61;
             }
             catch (ArgumentException e)
             {
                 DisplayExceptionMessage(e.Message);
             }
 
        }

        private static void ViewTestHeader(string header)
        {
            AlarmClock testConstructors = new AlarmClock();
            try
            {
                testConstructors = new AlarmClock(25, 62);
                testConstructors.TickTock();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine();
                DisplayExceptionMessage(e.Message);
                 
            }

        }
        
        //Method that displays errormessages for different properties in AlarmClock.cs
        private static void DisplayExceptionMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", message);
            Console.ResetColor();
        }
    }
}