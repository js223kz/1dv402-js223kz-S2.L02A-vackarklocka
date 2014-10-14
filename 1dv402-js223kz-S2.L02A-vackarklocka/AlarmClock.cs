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
        public int Hour
        {
            get
            {
                return _hour;
            }
            set{
               
                if(_hour > 23 || _hour < 0 ){

                    throw new ArgumentException();
                }
                _hour = value; 
            }
        }
        //Egenskap som kapslar in _minute
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (_minute > 59 || _minute < 0)
                {

                    throw new ArgumentException();
                }
                _minute = value;
            }
        }

        //Egenskap som kapslar in _alarmHour
        public int AlarmHour
        {
            get
            {
                return _alarmHour;
            }
            set
            {
                if (_alarmHour > 23 || _alarmHour < 0)
                {

                    throw new ArgumentException();
                }
                _alarmHour = value;
            }
        }
        
        //Egenskap som kapslar in _alarmMinute
        public int AlarmMinute
        {
            get
            {
                return _alarmMinute;
            }
            set
            {
                if (_alarmMinute > 59 || _alarmMinute < 0)
                {
                    throw new ArgumentException();
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
            _hour = hour;
            _minute = minute;
            _alarmHour = alarmHour;
            _alarmMinute = alarmMinute;
        }

        //KLockan ska ticka varje minut
       public bool TickTock()
        {
            _minute++;

             if(_minute > 59) {
                 _minute = 0;
                 _hour = _hour + 1;
             }
             
           if (_hour > 23)
             {
                 _hour = 0;
             }

             if (_hour == _alarmHour && _minute == _alarmMinute){
                
                 return true;
             }   
             
           return false;   
        }

       
        //Formatera klockslaget
       public string ToString()
        {

           string clockValue = String.Format("{0}{1}{2:0,0}", _hour, ":", _minute);
           string alarmValue = String.Format("{0}{1}{2}{3:0,0}{4}", '(', _alarmHour, ":", _alarmMinute, ')');

           return String.Format("{0, 10} {1, -5}", clockValue, alarmValue);
        }
    }
}
