using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionArrSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 6, 8, 7, 3 };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            arr.SortInsertion();
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
