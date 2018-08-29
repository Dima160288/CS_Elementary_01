using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_dec_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalCounter test = new DecimalCounter();
            Console.WriteLine(test.CounterValue);
            test.Decrease();
            Console.WriteLine(test.CounterValue);
            test.Increase();
            Console.WriteLine(test.CounterValue);

            DecimalCounter testVal = new DecimalCounter(25);
            Console.WriteLine(testVal.CounterValue);

            testVal.FillRand(20, 60);
            Console.WriteLine(testVal.CounterValue);
        }
    }
}
