using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSort
{
    abstract class AbsSort
    {
        public int intRangeA;
        public int intRangeB;
        public int[] arrDigits;

        public int[] Input()
        {
            Console.WriteLine("Введите по очереди диапазон случайных чисел, которые надо сортировать:");
            intRangeA = Convert.ToInt32(Console.ReadLine());
            intRangeB = Convert.ToInt32(Console.ReadLine());
            Random rndDigits = new Random();
            arrDigits = new int[20];
            for (int i = 0; i < arrDigits.Length; i++)
            {
                arrDigits[i] = rndDigits.Next(intRangeA, intRangeB);
            }
            return arrDigits;
        }  
        public abstract void Sort();

        public void Output()
        {
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < arrDigits.Length; i++)
            {
                Console.WriteLine(arrDigits[i]);
            }
            Console.ReadLine();
        }
    }

    class BubbleSort : AbsSort
    {
        public override void Sort()
        {
            int temp;
            for (int i = 0; i < arrDigits.Length - 1; i++)
            {
                for (int j = i + 1; j < arrDigits.Length; j++)
                {
                    if (arrDigits[i] > arrDigits[j])
                    {
                        temp = arrDigits[i];
                        arrDigits[i] = arrDigits[j];
                        arrDigits[j] = temp;
                    }
                }
            }
        }
    }

    class SelectionSort : AbsSort
    {
        public override void Sort()
        {
            int pos_min, temp;

            for (int i = 0; i < arrDigits.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arrDigits.Length; j++)
                {
                    if (arrDigits[j] < arrDigits[pos_min])
                    {
                        pos_min = j;
                    }
                }
                if (pos_min != i)
                {
                    temp = arrDigits[i];
                    arrDigits[i] = arrDigits[pos_min];
                    arrDigits[pos_min] = temp;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            AbsSort sort = new BubbleSort();
            sort.Input();
            sort.Sort();
            sort.Output();
            Console.WriteLine();
            AbsSort sort2 = new SelectionSort();
            sort.Input();
            sort.Sort();
            sort.Output();
        }
    }
}
