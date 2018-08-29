using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_04_HW_DLL
{
    class InsertionSort : AbstrArraySort
    {
        public override void SortArray(int[] arr)
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
        }
    }
}
