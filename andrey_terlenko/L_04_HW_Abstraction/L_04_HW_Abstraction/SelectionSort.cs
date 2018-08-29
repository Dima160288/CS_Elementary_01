using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_04_HW_Abstraction
{
    class SelectionSort : AbstrArraySort
    {
        public override void SortArray(int[] arr)
        {
            int min, temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }
    }
}
