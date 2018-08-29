using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.	Создать класс, содержащий динамический массив и количество элементов в нем.Добавить конструктор, 
//    который выделяет память под заданное количество элементов, и деструктор.
// Добавить методы, позволяющие
//    заполнять массив случайными числами, переставлять в данном массиве элементы в случайном порядке, 
//    находить количество различных элементов в массиве, выводить массив на экран.

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrClass TestArr = new ArrClass(10);
            TestArr.FillArrRandomly();

            Console.WriteLine("Выводим на экран сгенереный массив");
            TestArr.ShowArr();
            Console.WriteLine("\n\n Переставляем рандомно элементы");
            TestArr.RandomSort();
            TestArr.ShowArr();

            Console.WriteLine("\n\n Количество уникальных элементов в массиве: " + TestArr.CountDiffElements()); 

            Console.ReadKey();
        }
    }

    class ArrClass
    {
        int[] arr;

        public int[] Arr
        {
            get { return arr; }
        }


        public ArrClass()
        {
        }

        public ArrClass( int ArrSize)
        {
            arr = new int[ArrSize];
        }

        ~ArrClass()
        {
            Console.WriteLine("Мне хана...");
        }

        public void FillArrRandomly()
        {
            Random rand = new Random();
            for(int i =0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(1,11);
            }
        }

        public void ShowArr()
        {
            foreach(int item in Arr)
            {
                Console.Write(item + " ");
            }
        }

        public void RandomSort()
        {
            Random rand = new Random();
            int tempValue;
            int CopyFrom;

            int range = Arr.Length;

            for(int i =0; i< range;i++)
            {
                CopyFrom = rand.Next(0, range);
                tempValue = arr[i];

                arr[i] = arr[CopyFrom];
                arr[CopyFrom] = tempValue;
            }

        }

        public int CountDiffElements()
        {
            int Result = arr.Length;

            for(int i =0; i<arr.Length;i++)
            {
                for(int y = 0; y<arr.Length;y++)
                {
                    if(i != y && arr[i] == arr[y])
                    {
                        Result = Result-1;
                        break;
                    }
                }
            }

            return Result;
        }

    }

}
