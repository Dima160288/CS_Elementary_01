using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Создайте структуру с именем train, содержащую поля: название пункта назначения, номер поезда, время отправления.
     * Ввести данные в массив из пяти элементов типа train, упорядочить элементы по номерам поездов. 
     * Добавить возможность вывода информации о поезде, номер которого введен пользователем. 
     * Добавить возможность сортировки массив по пункту назначения, причем поезда с
     * одинаковыми пунктами назначения должны быть упорядочены по времени отправления. */
    public struct Train
    {
        private string point;
        private int number;
        private DateTime time;
        public string Point { get { return point; } }
        public int Number { get { return number; } }
        public string Time { get { return time.ToString(); } }
        public Train(string p, int n, DateTime t)
        {
            point = p;
            number = n;
            time = t;
        }
        public void Show()
        {
            Console.WriteLine("Train #{0} move to {1} at {2}", number, point, time);
        }
    }
    public static class T2
    {
        public static Train[] Init()
        {
            Train[] tr = new Train[5];
            Random r = new Random();
            string[] s = new string[] { "Boom", "Choo-choo", "Pew", "Bang", "Meow" };
            DateTime[] d = new DateTime[] { Convert.ToDateTime("12:23"), Convert.ToDateTime("07:03"), Convert.ToDateTime("22:20"), Convert.ToDateTime("17:47"), Convert.ToDateTime("00:00") };
            for (int i = 0; i < tr.Length; i++)
            {
                tr[i] = new Train(s[i], r.Next(), d[i]);
            }
            return tr;
        }
        public static Train[] SortByNumber(Train[] tr)
        {
            return tr.OrderBy(x => x.Number).ToArray();
        }
        public static void ShowOnNumber(Train[] tr, int n)
        {
            foreach (Train t in tr)
            {
                if (t.Number == n)
                    t.Show();
            }
        }
        public static Train[] SortByPoint(Train[] tr)
        {
            var t = tr.OrderBy(x => x.Point).ToArray();
            return t.GroupBy(x => x.Time).SelectMany(x => x).ToArray();
        }
    }
}
