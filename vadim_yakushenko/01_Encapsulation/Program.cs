using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Encapsulation
{
    class Statistics
    {
        private int successCount;
        private int totalCount;

        public void AccesCount(bool isSucces)
        {
            totalCount++;
            if (isSucces)
                successCount++;
        }

        public void PrintSuccessPercentage()
        {
            Console.WriteLine("{0}%", (100.0 * successCount) / totalCount);
        }
    }

    class Program
    {
        public static void Main()
        {
            var rnd = new Random();
            var stat = new Statistics();


            for (int i = 0; i < 1000; i++)
            {
                stat.AccesCount(rnd.Next(3) == 2);
            }


            stat.PrintSuccessPercentage();

            Console.ReadLine();
        }
    }


}
