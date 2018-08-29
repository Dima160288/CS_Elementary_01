using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_time
{
    class Time //было бы неплохо добавить формат
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours { get => hours; }
        public int Minutes { get => minutes; }
        public int Seconds { get => seconds; }

        public Time(int hours, int minutes = 0, int seconds = 0)
        {
            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
            {
                throw new ArgumentOutOfRangeException("Wrong values");
            }
            else
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
            }            
        }

        public void ChangeHrs(int newHr)
        {
            if (newHr < 0 || newHr > 23)
            {
                throw new ArgumentOutOfRangeException("You can only enter hours in range (0-23)");
            }
            else
            {
                hours = newHr;
            }
        }

        public void ChangeMin(int newMin)
        {
            if (newMin < 0 || newMin > 59)
            {
                throw new ArgumentOutOfRangeException("You can only enter minutes in range (0-59)");
            }
            else
            {
                minutes = newMin;
            }
        }

        public void ChangeSec(int newSec)
        {
            if (newSec < 0 || newSec > 59)
            {
                throw new ArgumentOutOfRangeException("You can only enter seconds in range (0-59)");
            }
            else
            {
                seconds = newSec;
            }
        }

        public void Show()
        {
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }

        public void AddSec(int added)
        {
            seconds += added;
            if (seconds > 59)
            {
                seconds %= 60;
                AddMin(1);
            }
        }

        public void AddMin(int added)
        {
            minutes += added;
            if (minutes > 59)
            {
                minutes %= 60;
                AddHr(1);
            }
        }

        public void AddHr(int added)
        {
            hours += added;
            if (hours > 23)
            {
                hours %= 24;
            }
        }
    }
}
