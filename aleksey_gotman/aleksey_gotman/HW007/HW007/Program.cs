using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW007
{
    public delegate double Calc(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            Calc add = (x, y) => x + y;
            Calc sub = (x, y) => x - y;
            Calc mul = (x, y) => x * y;
            Calc div = (x, y) => { if (y != 0) return x / y; else return Double.MaxValue; };
            double resAdd = add.Invoke(a, b);
            double resSub = sub.Invoke(a, b);
            double resMul = mul.Invoke(a, b);
            double resDiv = div.Invoke(a, b);
            Console.WriteLine("add - {0}; sub - {1}; mul - {2}; div - {3};", resAdd, resSub, resMul, resDiv);
            Console.ReadLine();
        }
    }
}
