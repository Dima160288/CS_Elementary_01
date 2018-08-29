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
            ArrayClass array = new ArrayClass(100);
            array.FillMethod();
            array.Display();
            array.RearrangeMethod();
            array.Display();
            array.FindElement(5);
            Console.ReadLine();
        }
    }

    class ArrayClass
    {
        int[] myArr;

        public ArrayClass(int countArr)
        {
            myArr = new int[countArr];
        }

        ~ArrayClass()
        {
            Console.WriteLine("Отработал деструктор");
        }

        public void FillMethod()
        {
            Random rnd = new Random();
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rnd.Next(0, 100);
            }
        }

        public void RearrangeMethod()
        {
            int tempIndex, randIndex;
            Random rnd = new Random();
            for (int i = 0; i < myArr.Length; i++)
            {
                randIndex = rnd.Next(0, myArr.Length - 1);
                tempIndex = myArr[i];
                myArr[i] = myArr[randIndex];
                myArr[randIndex] = tempIndex;
            }
        }

        public void FindElement(int element)
        {
            int count = 0;
            foreach (int s in myArr)
            {
                if (s == element)
                    count++;
            }
            Console.WriteLine("В массиве найдено {0} элементов с значением {1}", count, element);
        }

        public void Display()
        {
            int count = 0;
            foreach (int s in myArr)
            {
                count++;
                Console.WriteLine("Array[{0}] = {1}", count, s);
            }
        }
    }
}
