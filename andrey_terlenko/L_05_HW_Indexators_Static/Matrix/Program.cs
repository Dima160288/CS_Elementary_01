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
            MyMatrix test = new MyMatrix(6, 6);
            test.FillRand();
            test.ShowMatrix();
            Console.WriteLine("---------------------------");
            //test.ShowPartMatrix(2, 2);
            //test.DeleteColumn();
            //test.AddColumn();
            //test.ShowMatrix();
            Console.WriteLine(test.MaxValMatrix());
            Console.WriteLine(test.MinValMatrix());
            Console.WriteLine(test.SumAllElemMatrix());
            Console.WriteLine(test.AvgValMatrix());
            Console.WriteLine("---------------------------");
            test.OddValsMatrix();
        }
    }
}
