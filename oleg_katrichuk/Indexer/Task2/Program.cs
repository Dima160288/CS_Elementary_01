using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix my = new MyMatrix();
            my.CreateArray();
            Console.WriteLine();
            my.MaxValue();
            my.MinValue();
            my.SumValue();
            my.AveValue();
            my.OddValue();
            Console.ReadLine();
        }
    }

    class MyMatrix
    {
        private int[,] array;
        private int row = 0, col = 0;
        int sum = 0;
        readonly Random random = new Random();
        public void CreateArray()
        {
            Console.Write("Enter row in matrix : ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Enter column in matrix : ");
            col = int.Parse(Console.ReadLine());
            array = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = random.Next(2, 100);
                    Console.Write("\t " + array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void MaxValue()
        {
            int max = array[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (max < array[i, j])
                        max = array[i, j];
                }
            }
            Console.WriteLine("Max value is : {0}", max);
        }

        public void MinValue()
        {
            int min = array[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (min > array[i, j])
                        min = array[i, j];
                }
            }
            Console.WriteLine("Min value is : {0}", min);
        }

        public void SumValue()
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine("Sum element = {0}", sum);
        }

        public void AveValue()
        {
            double ave = (double)sum / array.Length;
            Console.WriteLine("Average array is : {0}", ave);
        }

        public void OddValue()
        {
            Console.Write("Odd values : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (array[i, j] % 2 != 0)
                        Console.Write(" " + array[i, j]);
                }
            }
        }
    }

}
