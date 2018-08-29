using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MyMatrix
    {
        private int[,] matrix;
        private int height;
        private int width;

        public MyMatrix(int height, int width)
        {
            this.height = height;
            this.width = width;
            matrix = new int[this.height, this.width];
        }

        public int this[int height, int width]
        {
            get
            {
                if ((height < 0 || height > this.height) || (width < 0 || width > this.width))
                {
                    Console.WriteLine("Entered indexes are wrong");
                    return 0;
                }
                else
                {
                    return matrix[height, width];
                }
            }
            set
            {
                if ((height < 0 || height > this.height) || (width < 0 || width > this.width))
                {
                    Console.WriteLine("Entered indexes are wrong");
                }
                else
                {
                    matrix[height, width] = value;
                }
            }
        }

        public void FillRand()
        {
            Random rand = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = rand.Next(0, 30);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ShowPartMatrix(int pHeight, int pWidth)
        {
            if ((pHeight < 0 || pHeight > height) || (pWidth < 0 || pWidth > width))
            {
                Console.WriteLine("Entered indexes are wrong");
            }
            else
            {
                for (int i = 0; i < pHeight; i++)
                {
                    for (int j = 0; j < pWidth; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void DeleteRow()
        {
            if (height - 1 == 0)
            {
                Console.WriteLine("Can't delete row");
            }
            else
            { 
                int[,] newMatrix = new int[height - 1, width];
                for (int i = 0; i < height - 1; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                }
                matrix = newMatrix;
                height--;
            }
        }

        public void DeleteColumn()
        {
            if (width - 1 == 0)
            {
                Console.WriteLine("Can't delete column");
            }
            else
            {
                int[,] newMatrix = new int[height, width - 1];
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width - 1; j++)
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                }
                matrix = newMatrix;
                width--;
            }
            
        }

        public void AddRow()
        {
            int[,] newMatrix = new int[height + 1, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
            matrix = newMatrix;
            height++;
        }

        public void AddColumn()
        {
            int[,] newMatrix = new int[height, width + 1];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
            matrix = newMatrix;
            width++;
        }

        public int MaxValMatrix()
        {
            int maxVal = matrix[0, 0];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (matrix[i, j] > maxVal)
                    {
                        maxVal = matrix[i, j];
                    }
                }
            }
            return maxVal;
        }

        public int MinValMatrix()
        {
            int minVal = matrix[0, 0];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (matrix[i, j] < minVal)
                    {
                        minVal = matrix[i, j];
                    }
                }
            }
            return minVal;
        }

        public int SumAllElemMatrix()
        {
            int sum = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        public double AvgValMatrix()
        {
            int avg = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    avg += matrix[i, j];
                }
            }
            avg /= (height * width);
            return avg;
        }

        public void OddValsMatrix()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
