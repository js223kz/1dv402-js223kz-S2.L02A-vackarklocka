using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_js223kz_S2.L02A_vackarklocka
{
    public class AlarmClock
    {
        private int _Hour;
        private int _Minute;
        private int _AlarmHour;
        private int _AlarmMinute;

        //Egenskap som kapslar in _hour
        public int Hour{
            get{
                return _Hour;
            }
            set{
               
                if(value > 24 || value < 0 ){

                    throw new ArgumentException("Timmen är inte i intervallet 0-23.");
                }
                _Hour = value; 
            }
        }
        
        //Egenskap som kapslar in _minute
        public int Minute{
            get{
                return _Minute;
            }
            set{
                if (value > 60|| value < 0)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59.");
                }

                _Minute = value;
            }
        }

        //Egenskap som kapslar in _alarmHour
        public int AlarmHour{
            get{
                return _AlarmHour;
            }
            set{
                if (value > 24 || value < 0)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23.");
                }
                _AlarmHour = value;
            }
        }
        
        //Egenskap som kapslar in _alarmMinute
        public int AlarmMinute{
            get{
                return _AlarmMinute;
            }
            set{
                if (value > 60 || value < 0)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59.");
                }
                _AlarmMinute = value;
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
            _Hour = hour;
            _Minute = minute;
            _AlarmHour = alarmHour;
            _AlarmMinute = alarmMinute;
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
