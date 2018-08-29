using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_05_06_ExtensionArrSort_HW_DLL
{
    static class SortArr
    {
        public static int[] SortInsertion(this int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i;
                while (j > 0 && current < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = current;
            }
            return arr;
        }
    }
}
