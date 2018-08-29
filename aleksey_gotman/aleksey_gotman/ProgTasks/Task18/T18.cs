using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    /*18.	Класс Абонент: Идентификационный номер, Фамилия, Имя, Отчество, Адрес, Номер кредитной карточки, Дебет, Кредит, Время междугородных и городских переговоров; Конструктор; Методы: установка значений атрибутов, получение значений атрибутов, вывод информации. Создать массив объектов данного класса. Вывести сведения относительно абонентов, у которых время городских переговоров превышает заданное.  Сведения относительно абонентов, которые пользовались междугородной связью. Список абонентов в алфавитном порядке.*/
    public static class T18
    {
        public static void DoIt()
        {
            List<Subscriber> subscribers = new List<Subscriber>();
            subscribers.Add(new Subscriber("a", "aa", "aaa", 1, 1234567891234567, 53.5, 0, new TimeSpan(10, 10, 10), new TimeSpan(5, 5, 5)));
            List<Subscriber> lim = subscribers.Where(x => x.TimeIn > Subscriber.limitOut).ToList();
            foreach (Subscriber s in lim)
                s.Show();
            lim = subscribers.Where(x => x.TimeIn > TimeSpan.Zero).ToList();
            foreach (Subscriber s in lim)
                s.Show();
            lim = subscribers.OrderBy(x => x.FirstName).ToList();
            foreach (Subscriber s in lim)
                s.Show();
        }
    }
    public class Subscriber
    {
        double debet;
        double kredit;
        TimeSpan timeIn;
        TimeSpan timeOut;
        public static TimeSpan limitOut;
        public int Id { get; }
        public double Debet { get { return debet; } }
        public double Kredit { get { return kredit; } }
        public TimeSpan TimeIn { get { return timeIn; } }
        public TimeSpan TimeOut { get { return timeOut; } }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public long KreditKard
        {
            set
            {
                if (value > 0 && value.ToString().Length == 16)
                    KreditKard = value;
            }
            get { return KreditKard; }
        }
        public Subscriber(string f, string s, string p, int id, long kk, double k, double d, TimeSpan i, TimeSpan o)
        {
            KreditKard = kk;
            id = Id;
            debet = d;
            kredit = k;
            FirstName = f;
            SecondName = s;
            Patronymic = p;
            timeIn = i;
            timeOut = o;
        }
        public void ResetTime()
        {
            timeIn = TimeSpan.Zero;
            timeOut = TimeSpan.Zero;
        }
        public void AddTimeIn(TimeSpan t)
        {
            timeIn += t;
        }
        public void AddTimeOut(TimeSpan t)
        {
            timeOut += t;
        }
        public void AddMoney(double trash)
        {
            if (kredit != 0)
            {
                kredit -= trash;
                if (kredit > 0)
                {
                    debet += (-1) * kredit;
                    kredit = 0;
                }
            }
            else
            {
                debet += trash;
            }
        }
        public void TakeMoney(double trash)
        {
            if (debet != 0)
            {
                debet -= trash;
                if (debet > 0)
                {
                    kredit += (-1) * debet;
                    debet = 0;
                }
            }
            else
            {
                kredit += trash;
            }
        }
        public void Show()
        {
            Console.WriteLine("Subscriber: {0} {1} {2}. Id {3}", FirstName, SecondName, Patronymic, Id);
            Console.WriteLine("Kredit kard #{0} Debet: {1}, Kredit: {2}");
            Console.WriteLine("Time on city: {0}, Time out city: {1}", TimeIn, TimeOut);
        }
    }
}
