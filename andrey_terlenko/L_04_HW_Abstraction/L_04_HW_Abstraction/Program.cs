using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_04_HW_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] arr = new int[15];
            AbstrArraySort test = new InsertionSort();
            test.FillArrRand(arr);
            test.ShowArr(arr);
            test.SortArray(arr);
            test.ShowArr(arr);

            int[] arr1 = new int[25];
            AbstrArraySort test1 = new SelectionSort();
            test1.FillArrRand(arr1);
            test1.ShowArr(arr1);
            test1.SortArray(arr1);
            test1.ShowArr(arr1);

        }
    }
}
