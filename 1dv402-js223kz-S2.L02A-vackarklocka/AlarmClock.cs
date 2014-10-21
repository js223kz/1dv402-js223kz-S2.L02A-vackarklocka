using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_js223kz_S2.L02A_vackarklocka
{
    public class AlarmClock
    {
        private int _hour;
        private int _minute;
        private int _alarmHour;
        private int _alarmMinute;

        //Egenskap som kapslar in _hour
        public int Hour{
            get{
                return _hour;
            }
            set{
               
                if(value > 24 || value < 0 ){

                    throw new ArgumentException("Timmen är inte i intervallet 0-23.");
                    
                }
                _hour = value; 
            }
        }
        
        //Egenskap som kapslar in _minute
        public int Minute{
            get{
                return _minute;
            }
            set{
                if (value > 60|| value < 0)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59.");
                }

                _minute = value;
            }
        }

        //Egenskap som kapslar in _alarmHour
        public int AlarmHour{
            get{
                return _alarmHour;
            }
            set{
                if (value > 24 || value < 0)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23.");
                }
                _alarmHour = value;
            }
        }
        
        //Egenskap som kapslar in _alarmMinute
        public int AlarmMinute{
            get{
                return _alarmMinute;
            }
            set{
                if (value > 60 || value < 0)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59.");
                }
                _alarmMinute = value;
            }
        }

        /// kontruktorerna 3 st till antalet
        public AlarmClock()
            : this(0, 0)
        {

        }

        public AlarmClock(int hour, int minute) 
            : this(hour, minute, 0, 0)
        {
       
        }
    
        
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute) 
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        //KLockan ska ticka varje minut
        public bool TickTock()
        {

            Minute++;
            if (Minute == 60)
            {
                Minute = 0;
                Hour = Hour + 1;
            }

            if (Hour == 24)
            {
                Hour = 0;
            }
                

           if (Hour == AlarmHour && Minute == AlarmMinute){
                 return true;
             }
             else{
                 return false; 
             } 
        }

       
        //Formatera klockslaget
       public override string ToString()
        {

           string clockValue = String.Format("{0}{1}{2:0,0}", Hour, ":", Minute);
           string alarmValue = String.Format("{0}{1}{2}{3:0,0}{4}", '(', AlarmHour, ":", AlarmMinute, ')');

           return String.Format("{0, 10} {1, -5}", clockValue, alarmValue);
        }
    }
}
