using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 23, 56, -78, 45, 123, 0, 45 };
            array.Sort();
            foreach (var element in array)
            {
                Console.Write(" " + element);
            }
            Console.ReadLine();
        }
    }

    static class MyClass
    {

        public static void Sort(this int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }

}
