using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_DynamicArr
{
    class DynamicArr
    {
        private int[] arr;
        private int size;
        public int[] Arr { get => arr; set => arr = value; }
        public int Size { get => size; set => size = value; }

        public DynamicArr (int size)
        {
            this.size = size;
            this.arr = new int[size];
        }

        ~DynamicArr()
        {
            Console.WriteLine("Destructor : DynamicArr()");
        }
        /// <summary>
        /// Указать минимальные максимальные значени FillArrRandom
        /// </summary>        
        public void FillArrRandom(int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(min, max+1);
            }           
        }

        public void RandomizePosition()
        {
            Random random = new Random();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int j = random.Next(i);
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        public int SummOfElements(int a, int b)
        {
            int summ = arr[a - 1] + arr[b - 1];
            Console.WriteLine($"Summ of elements {a} and {b} is {summ}");
            return summ;

        }

        public int SummOfAllElements()
        {
            return arr.Sum();
        }

        public void NewSize(int size)
        {
            int[] newsizeArr = new int[size];
            if (size > arr.Length)
            {
                arr.CopyTo(newsizeArr, 0);
                arr = newsizeArr;    
            }
            else if (size < arr.Length)
            {
                for (int i = 0; i < newsizeArr.Length; i++)
                {
                    arr[i] = newsizeArr[i];
                }
            }            
            else { arr = newsizeArr; }
        }


        public void ShowArr()
        {
            foreach (var item in arr)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine();
        }
    }
}
