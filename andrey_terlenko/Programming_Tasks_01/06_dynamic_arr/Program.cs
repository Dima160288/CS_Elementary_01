using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_dynamic_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArr test = new DynamicArr(10);
            test.FillRand(10, 50);
            test.ShowArr();
            /*test.ShuffleArr();
            test.ShowArr();
            Console.WriteLine(test.CountDifferentElems());*/
            DynamicArr qwerty = new DynamicArr(test.Arr, 5);
            qwerty.ShowArr();
        }
    }
}
