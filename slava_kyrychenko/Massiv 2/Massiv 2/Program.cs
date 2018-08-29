using System;

namespace Massiv_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations arrOper = new ArrayOperations();
            int[] arr = arrOper.CreateRandomArray(); //Create array, inputs  min , max value randoms elements
            arrOper.ShowOperations(arr);


        }

    }

    class ArrayOperations
    {
        public  int[] CreateRandomArray()
        {
            Console.WriteLine("Создан массив в 100 элементов, " +
                " для его заполнения введите минимальное и максимальное значение");
            Random r = new Random();
           int[] arr = new int[100];
            int minValue = Convert.ToInt32(Console.ReadLine());
            int maxValue = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(minValue,maxValue);
            }
            return arr;
        }
        public void ShowOperations(params int [] arr)
        {
            int maxIndex=0, minIndex = 50;
            int summArr = 0, srOrifmet = 0;
            int[] arrNechetnie;
            for (int i = 0; i < arr.Length; i++)
            {
                summArr = summArr + arr[i]; // summ elements value

                if (arr[i] > maxIndex)   // max index
                    maxIndex = arr[i];
                if (arr[i] < minIndex)   //min index
                    minIndex = arr[i];
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine("Нечетные значения элементов массива  {0}",arr[i]); 
                }
            }
            srOrifmet = summArr / arr.Length; // orifmet srednee

           

            Console.WriteLine("Минимальный элемент массива {0} ,  максимальный элемент {1} ",minIndex, maxIndex);
            Console.WriteLine(new string ( '-' ,40 ));

            Console.WriteLine("Сумма элементов массива равна {0}", summArr);
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Среднее орифметическое всех элементов {0}", srOrifmet);

        }

    }
}
