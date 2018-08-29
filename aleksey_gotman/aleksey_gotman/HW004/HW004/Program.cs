using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW004
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractSort s = new InsertionSort();
            s.arr = new int[] { 2, 5, 3, 7, 5 };
            s.Show();
            s.Sort();
            s.Show();
            Console.ReadLine();
        }
    }
}
