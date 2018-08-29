using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW004
{
    public abstract class AbstractSort
    {
        public int[] arr;
        public abstract void Sort();
        public void Show()
        {
            foreach (int i in arr)
                Console.Write(i);
            Console.WriteLine();
        }
    }

    public class MergeSort : AbstractSort
    {
        public override void Sort()
        {
            arr = Sort1(arr);
        }
        static int[] Sort1(int[] arr)
        {
            if (arr.Length == 1)
                return arr;
            Int32 mid_point = arr.Length / 2;
            return Merge(Sort1(arr.Take(mid_point).ToArray()), Sort1(arr.Skip(mid_point).ToArray()));
        }
        static Int32[] Merge(Int32[] mass1, Int32[] mass2)
        {
            Int32 a = 0, b = 0;
            Int32[] merged = new int[mass1.Length + mass2.Length];
            for (Int32 i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b])
                        merged[i] = mass2[b++];
                    else //if int go for
                        merged[i] = mass1[a++];
                else
                  if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }
    }

    public class InsertionSort : AbstractSort
    {
        public override void Sort()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int cur = arr[i];
                int j = i;
                while (j > 0 && cur < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = cur;
            }
        }
    }
}
