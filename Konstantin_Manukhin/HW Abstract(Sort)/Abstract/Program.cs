using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int arrLen = 10;
            int[] arr = new int[arrLen];
            int[] arr1 = new int[arrLen];
            Sorting sortingBubble = new BubbleSort();
            Sorting sortingSelect = new SelectionSort();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = rand.Next(0, 100);
            }

            sortingBubble.sort(arr);
            Console.WriteLine();
            sortingSelect.sort(arr1);
        }
    }

    abstract class Sorting
    {
        public int temp;
        abstract public void sort(int[] arr);
    }

    class BubbleSort : Sorting
    {
        public override void sort(int[] arr)
        {
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    class SelectionSort : Sorting
    {
        public override void sort(int[] arr1)
        {
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[j] < arr1[min])
                    {
                        min = j;
                    }
                }
                temp = arr1[min];
                arr1[min] = arr1[i];
                arr1[i] = temp;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
    }
}
