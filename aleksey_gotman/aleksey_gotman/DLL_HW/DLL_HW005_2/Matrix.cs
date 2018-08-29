using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW005_2
{
    public class Matrix
    {
        private int[,] matrix;
        private int i;
        private int j;
        public Matrix(int i, int j)
        {
            matrix = new int[i, j];
            this.i = i;
            this.j = j;
        }
        public int this[int i, int j]
        {
            get
            {
                if (i < 1 || i > this.i || j < 1 || j > this.j)
                {
                    Console.WriteLine("Wrong index!");
                    return 0;
                }

                else
                    return matrix[i - 1, j - 1];
            }
            set
            {
                if (i < 1 || i > this.i || j < 1 || j > this.j)
                    Console.WriteLine("Wrong index!");
                else
                    matrix[i - 1, j - 1] = value;
            }
        }
        public void Show()
        {
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    Console.Write(matrix[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Max()
        {
            int m = int.MinValue;
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    if (matrix[a, b] > m)
                        m = matrix[a, b];
                }
            }
            Console.WriteLine("Maximum - " + m);
        }
        public void Min()
        {
            int m = int.MaxValue;
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    if (matrix[a, b] < m)
                        m = matrix[a, b];
                }
            }
            Console.WriteLine("Minimum - " + m);
        }
        public void Sum()
        {
            int m = 0;
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    m = m + matrix[a, b];
                }
            }
            Console.WriteLine("Sum - " + m);
        }
        public void Avg()
        {
            int m = 0;
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    m = m + matrix[a, b];
                }
            }
            Console.WriteLine("Averrage - " + m / (i * j));
        }
        public void Odd()
        {
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    if (matrix[a, b] % 2 != 0)
                        Console.Write(matrix[a, b] + " ");
                }
            }
            Console.WriteLine();
        }
        public void AddRow()
        {
            int[,] nm = new int[i + 1, j];
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    nm[a, b] = matrix[a, b];
                }
            }
            matrix = nm;
            i = i + 1;
        }

        public void AddColumn()
        {
            int[,] nm = new int[i, j + 1];
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    nm[a, b] = matrix[a, b];
                }
            }
            matrix = nm;
            j = j + 1;
        }

        public void RemRow()
        {
            if (i - 1 == 0)
                throw new IndexOutOfRangeException();
            int[,] nm = new int[i - 1, j];
            for (int a = 0; a < i - 1; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    nm[a, b] = matrix[a, b];
                }
            }
            matrix = nm;
            i = i - 1;
        }

        public void RemColumn()
        {
            if (j - 1 == 0)
                throw new IndexOutOfRangeException();
            int[,] nm = new int[i, j - 1];
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j - 1; b++)
                {
                    nm[a, b] = matrix[a, b];
                }
            }
            matrix = nm;
            j = j - 1;
        }

    }
}
