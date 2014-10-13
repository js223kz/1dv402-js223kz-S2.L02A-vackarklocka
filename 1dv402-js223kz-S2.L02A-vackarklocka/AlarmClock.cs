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

        public int Minute
        {
            get
            {
                return _minute;
            }
            set{
                if(_minute > 59 || _minute < 0 ){

                    throw new ArgumentException();
                }
                _minute = value;
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

            DateTime clock = new DateTime();
            clock = DateTime.Now;
            hour = clock.Hour;
            minute = clock.Minute;

            _hour = hour;
            _minute = minute;
            _alarmHour = alarmHour;
            _alarmMinute = alarmMinute;
        }

       public bool TickTock()
        {
           while (_minute < 60)
            {
                _minute++;

                if(_minute == 59) {
                    _minute = 0;
                    _hour = _hour + 1;
                }

                if (_hour == _alarmHour && _minute == AlarmMinute)
                {
                    return true;
                }
            }
             return false;    
        }

        public string ToString(string clockValue, string minute, string hour)
        {
            minute = Convert.ToString(_minute);
            hour = Convert.ToString(_hour);

            clockValue =String.Format ("{0}{1}{2}", hour, ":", minute);

            return clockValue;
        }
    }
}
