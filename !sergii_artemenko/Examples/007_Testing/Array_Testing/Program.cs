using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {3, 5, 7, 1, 9};
            int A = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * 2;  
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - A;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();

        }      
    }
}
