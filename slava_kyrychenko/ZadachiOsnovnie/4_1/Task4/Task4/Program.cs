using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo rdk;
            Counter counter = null;
            Program.RandomOrUserInput(out rdk, ref counter);
            do
            {
                Console.WriteLine("Для + или -  нажмите ↑  ↓, \n\n");
                rdk = Console.ReadKey();
                switch (rdk.Key.ToString())
                {
                    case "UpArrow": { counter.MethodUP(); Console.WriteLine("{0}", counter.Count); break; }
                    case "DownArrow": { counter.MethodDn(); Console.WriteLine(counter.Count); break; }
                }
            }
            while (true);
        }
        public static void RandomOrUserInput(out ConsoleKeyInfo rdk, ref Counter counter)
        {
            Random rnd = new Random();
            Console.WriteLine(" RANDOM start       <<         клавиша лево - право        >>       USER INPUT  ");
            rdk = Console.ReadKey();

            if (rdk.Key.ToString() == "LeftArrow")
            {
                Thread.Sleep(500);
                counter = new Counter(10, rnd.Next(0, 40), rnd.Next(40, 100));
                Console.WriteLine("Рандомно установлены параметры счетчика: " +
                    "\n старт {0},  мин значение {1},  макс значение {2}", counter.Count, counter.low, counter.hig);
            }

            if (rdk.Key.ToString() == "RightArrow")
            {
                Console.WriteLine("Введите число с которого стартует счетчик");
                int p1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("задайте диапозон работы счетчика, введите два числа");
                int p2 = Convert.ToInt32(Console.ReadLine());
                int p3 = Convert.ToInt32(Console.ReadLine());
                counter = new Counter(p1, p2, p3);
            }
        }
    }

    class Counter
    {
        int count;
        public int low;
        public int hig;

        public Counter(int count, int low, int hig)
        {
            this.low = low;
            this.hig = hig;
            if (count > hig | count < low)
            {
                this.count = (low + hig) / 2;
                Console.WriteLine("Начальное значение счетчика выходит за указанный диапозон," +
                    "установлено значение в середине диапозона  {0}", this.count);
            }
            else
                this.count = count;
        }

        public int Count
        {
            get { return count; }
        }

        public void MethodUP()
        {
            if (count < hig)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                count++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Счетчик ограничен значением {0}\n", hig);
                Console.Beep();
            }
        }

        public void MethodDn()
        {
            if (count > low)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                count--;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Счетчик ограничен значением {0}\n", low);
                Console.Beep();
            }
        }
    }
}
