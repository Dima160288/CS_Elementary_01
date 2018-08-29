using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    /*Составить описание класса для представления времени. Предусмотреть возможности установки времени и изменения его отдельных полей (час, минута, секунда) с проверкой допустимости вводимых значений. В случае недопустимых значений полей выбрасываются исключения. Создать методы изменения времени на заданное количество часов, минут и секунд.*/
    public class T13
    {

    }
    public class Time
    {
        int second;
        int minutes;
        int hours;
        public int Second
        {
            set
            {
                if (value > 59 || value < 0)
                    throw new Exception();
                else
                    second = value;
            }
            get { return second; }
        }
        public int Minutes
        {
            set
            {
                if (value > 59 || value < 0)
                    throw new Exception();
                else
                    minutes = value;
            }
            get { return minutes; }
        }
        public int Hours
        {
            set
            {
                if (value > 23 || value < 0)
                    throw new Exception();
                else
                    hours = value;
            }
            get { return hours; }
        }
        public Time(int hour = 0, int min = 0, int sec = 0)
        { 
            Hours = hour;
            Minutes = min;
            Second = sec;
        }
        public Time(string time)
        {
            string[] t;
            if (time.Contains(':'))
                t = time.Split(':');
            else if (time.Contains(' '))
                t = time.Split(' ');
            else if (time.Contains('-'))
                t = time.Split('-');
            else if (time.Contains(','))
                t = time.Split(',');
            else
                throw new Exception();
            Hours = Convert.ToInt32(t[0]);
            Minutes = Convert.ToInt32(t[1]);
            Second = Convert.ToInt32(t[2]);
        }
        public void Show()
        {
            string h = hours.ToString();
            string m = minutes.ToString();
            string s = second.ToString();
            if (hours / 10 == 0)
                h = "0" + hours.ToString();
            if (minutes / 10 == 0)
                m = "0" + minutes.ToString();
            if (second / 10 == 0)
                s = "0" + second.ToString();
            Console.WriteLine("Time is {0}:{1}:{2}", h, m, s);
        }
        public void AddSec(int add)
        {
            second += add % 60;
            AddMin(add / 60);
        }
        public void AddMin(int min)
        {
            minutes += min % 60;
            AddHour(min / 60);
        }
        public void AddHour(int hour)
        {
            hours += hour;
            hours = hours % 24;
        }
        public void AddTime(int hour = 0, int min = 0, int sec = 0)
        {
            AddSec(sec);
            AddMin(min);
            AddHour(hour);
        }
    }

}
