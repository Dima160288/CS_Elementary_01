using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(3,3);
            matrix.Show();

            Console.WriteLine(new string('-',30));
            Console.WriteLine("[1][2] = {0}",matrix[1,2]);
            matrix[0, 0] = 10;

            Console.WriteLine(new string('-', 30));
            matrix.Size(5,4);
            matrix.Show();

            Console.WriteLine(new string('-', 30));
            matrix.ShowPart(1,0,3,3);
            Console.ReadLine();
        }
    }

    class MyMatrix
    {
        private int[][] matrix;
        public MyMatrix(int n, int m)
        {
            matrix = new int[Math.Abs(n)][];
            for (int i = 0; i < Math.Abs(n); i++)
            {
                matrix[i] = new int[Math.Abs(m)];
            }
            Rand();
        }

        public void Rand()
        {
            Random random = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = random.Next(100);
                }
            }
        }
        public void Size(int row, int col)
        {
            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("Size matrix is wrong");
                return;
            }
            int[][] newMatrix = new int[row][];
            for (int i = 0; i < row; i++)
            {
                newMatrix[i] = new int[col];
            }

            for (int i = 0; i < Math.Min(matrix.Length, row); i++)
            {
                for (int j = 0; j < Math.Min(matrix[i].Length, col); j++)
                {
                    newMatrix[i][j] = matrix[i][j];
                }
            }
            Random random = new Random();
            if (row > matrix.Length)
            {
                for (int i = matrix.Length; i < row; i++)
                {
                    for (int j = 0; j < Math.Min(col, matrix[0].Length); j++)
                    {
                        newMatrix[i][j] = random.Next(100);
                    }
                }
            }
            if (col > matrix[0].Length)
            {
                for (int i = matrix[0].Length; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        newMatrix[j][i] = random.Next(100);
                    }
                }
            }
            matrix = newMatrix;
        }

        public void ShowPart(int startR, int startC, int endR, int endC)
        {
            if (startR < 0 || startC < 0 || endR > matrix.Length || endC > matrix[0].Length)
            {
                Console.WriteLine("Index beyond the array limit"); return;
            }
            if (startR > endR || startC > endC)
            {
                Console.WriteLine("Wrong coordinates"); return;
            }
            for (int i = startR; i < endR; i++)
            {
                for (int j = startC; j < endC; j++)
                {
                    Console.Write("{0} ", matrix[i][j]);
                    
                }
                Console.WriteLine();

            }
        }

        public void Show()
        {
            ShowPart(0, 0, matrix.Length, matrix[0].Length);
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    return matrix[index1][index2];
                Console.WriteLine("Index beyond the array limit");
                return 0;
            }
            set
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    matrix[index1][index2] = value;
                Console.WriteLine("Write out of array");
            }
        }



    }

}
