using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_dynamic_arr
{
    class DynamicArr
    {
        private int[] arr;
        private int size;

        public int[] Arr { get => arr; }
        public int Size { get => size; }

        public DynamicArr(int size)
        {
            this.size = size;
            arr = new int[size];
        }

        public DynamicArr(int[] oldArr, int newSize)
        {
            if (newSize < oldArr.Length)
            {
                arr = new int[newSize];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = oldArr[i];
                }
            }
            else
            {
                arr = new int[newSize];
                oldArr.CopyTo(arr, 0);
            }           
        }

        ~DynamicArr()
        {
            Console.WriteLine("Object of class DynamicArr is disposed of");
        }

        public void FillRand(int minVal, int maxVal)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(minVal, maxVal + 1);
            }
        }

        public void ShowArr()
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void ShuffleArr() //Fisher–Yates shuffle
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int j = rand.Next(0, i + 1);
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        public int CountDifferentElems()
        {
            int count = arr.Distinct().Count();
            return count;
        }
    }
}
