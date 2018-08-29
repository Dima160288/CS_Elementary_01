using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            Console.WriteLine("Enter rows count:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter columns count:");
            int j = Convert.ToInt32(Console.ReadLine());
            Matrix m = new Matrix(i,j);
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    m[a, b] = rnd.Next(0, 10);
                }
            }
            m.Show();
            m.RemColumn();
            m.Show();
            m.AddRow();
            m.Show();
            Console.ReadLine();
        }
    }
}
