﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Encapsulation
{
    class Statistics
    {
        public int SuccessCount;
        public int TotalCount;

        public void PrintSuccessPercentage()
        {
            Console.WriteLine("{0}%", (100.0 * SuccessCount) / TotalCount);
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
                stat.TotalCount++;
                if (rnd.Next(3) == 2)
                    stat.SuccessCount++;
            }

            stat.PrintSuccessPercentage();

            Console.ReadLine();
        }
    }


}