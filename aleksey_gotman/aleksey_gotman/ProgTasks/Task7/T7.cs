using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    /*Составить описание класса для определения одномерных массивов строк фиксированной длины. 
     * Предусмотреть контроль выхода за пределы массива, возможность обращения к отдельным строкам массива по индексам, 
     * выполнения операций поэлементного сцепления двух массивов с образованием нового массива, слияния двух массивов с исключением повторяющихся элементов, 
     * а также вывод на экран элемента массива по заданному индексу и всего массива.*/
    public static class T7
    {
        public static StrArr Concatination(StrArr a, StrArr b)
        {
            int maxLengt = a.Length() + b.Length();
            int length = 0;
            if (a.MaxLength > b.MaxLength)
                length = a.MaxLength;
            else
                length = b.MaxLength;
            var arr = new StrArr(length, maxLengt);
            for (int i = 0; i<length; i++)
            {
                if (i % 2 == 0)
                    arr[i] = a[i % 2];
                else
                    arr[i] = b[i % 2];
            }
            return arr;
        }
        public static StrArr UniqueConcat(StrArr a, StrArr b)
        {
            int length = 0;
            if (a.Length() > b.Length())
                length = a.Length();
            else
                length = b.Length();
            var arr = new StrArr(length, a.MaxLength + b.MaxLength);
            int[] x = new int[10];
            for (int i = 0; i < length; i++)
            {
                if (a[i] == b[i])
                    arr[i] = a[i];
                else
                    arr[i] = a[i] + b[i];
            }
            return arr;
        }
    }
    public class StrArr
    {
        private string[] array;
        private int maxLength;
        public int MaxLength { get { return maxLength; } }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                {
                    Console.WriteLine("Out of range");
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    if (value.Length < maxLength)
                        array[index] = value;
                    else
                        Console.WriteLine("Out of range");
            }

        }
        public StrArr(int i, int maxLength)
        {
            array = new string[i];
            this.maxLength = maxLength;
        }
        public void Show()
        {
            foreach (string s in array)
                Console.WriteLine(s);
        }
        public void Show(int i)
        {
            if (i >= 0 && i < array.Length)
                Console.WriteLine(array[i]);
            else
                Console.WriteLine("Out of range");
        }
        public int Length()
        {
            return array.Length;
        }
    }
}
