using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSort
{
    abstract class Sort
    {
        public abstract void Method1Sort();
        public abstract void Method2Sort();
    }

    class Concrete1Sort : Sort
    {
        private readonly int[] array = new int[10000];
        Random rand=new Random();        
        //bubble sort        
        public override void Method1Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 1000);
            }
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }

        }             
        
        //selection sort 
        public override void Method2Sort()
        {


            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }
    }

    class Concrete2Sort : Sort
    {
        private readonly int[] array = new int[10000];
        Random rand = new Random();
        //sort insert
        public override void Method1Sort()
        {
            for (int k = 0; k < array.Length; k++)
            {
                array[k] = rand.Next(1, 1000);
            }
            int x = 0, i = 0, j = 0;
            for (i = 0; i < array.Length; i++)
            {
                x = array[i];
                for (j = i - 1; j >= 0 && array[j] > x; j--)
                    array[j + 1] = array[j];

                array[j + 1] = x;
            }
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }

        //quick sort
        public override void Method2Sort()
        {
            Sort(array, 0, array.Length - 1);
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }

        }

        public void Sort(int[] arr, int l, int r)
        {
            int i = l;
            int j = r;
            int x = arr[(l + r) / 2];

            while (i <= j)
            {

                while (arr[i] < x) i++;
                while (arr[j] > x) j--;

                if (i <= j)
                {

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (l < j) Sort(arr, l, j);
            if (i < r) Sort(arr, i, r);
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
                Concrete1Sort cs = new Concrete1Sort();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Console.Write("Bubble sort : ");
                cs.Method1Sort();
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine("Bubble sort milisecond : {0} ",elapsedMs);

                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                Console.Write("Selection sort : ");
                cs.Method2Sort();
                watch1.Stop();
                var elapsedMs1 = watch.ElapsedMilliseconds;
                Console.WriteLine("Selection sort milisecond : {0} ",elapsedMs1);

                Concrete2Sort cs2 = new Concrete2Sort();
                var watch2 = System.Diagnostics.Stopwatch.StartNew();
                Console.Write("Insert sort : ");
                cs2.Method1Sort();
                watch2.Stop();
                var elapsedMs2 = watch.ElapsedMilliseconds;
                Console.WriteLine("Insert sort milisecond : {0} ",elapsedMs2);

                var watch3 = System.Diagnostics.Stopwatch.StartNew();
                Console.Write("Quick sort : ");
                cs2.Method2Sort();
                watch3.Stop();
                var elapsedMs3 = watch.ElapsedMilliseconds;
                Console.WriteLine("Quick sort milisecond : {0} ", elapsedMs3);

            Console.ReadLine();
            }
        }

    }
