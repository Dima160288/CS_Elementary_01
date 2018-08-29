using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Counter
    {
        int counter;
        int min;
        int max;

        public Counter()
        {
            this.counter = 0;
            this.min = 0;
            this.max = 10;
        }
        public Counter (int counter)
        {
            this.counter = counter;
            this.min = 0;
            this.max = 10;
            try
            {
                if (counter > this.max)
                {
                    counter = this.max;
                }
            }
            catch (Exception)
            {
                if (counter > max)
                {
                    throw new Exception("Провышено допустимое значение");
                }
            }
        }
        public void RandomCounter()
        {
            Random random = new Random();
            this.counter = random.Next(1, 11);
        }
        public int Status
        {
            get
            {
                return this.counter;
            }
        }
        public void Increase()
        {
            this.counter++;
            try
            {
                if (this.counter > this.max)
                {
                    this.counter = this.max;
                }
            }
            catch (Exception)
            {
                if (counter > max)
                {
                    throw new Exception("Провышено допустимое значение");
                }
            }                       
        }
        public void Decrease()
        {
            this.counter--;
            if (counter < min)
            {
                throw new Exception("Превышено допустимое значение");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter cnt = new Counter();
            Console.WriteLine(cnt.Status);

            cnt.Increase();
            Console.WriteLine(cnt.Status);

            cnt = new Counter(5);
            Console.WriteLine(cnt.Status);

            cnt.Decrease();
            Console.WriteLine(cnt.Status);

            cnt.RandomCounter();
            Console.WriteLine(cnt.Status);

            Console.ReadLine();
        }
    }
}
