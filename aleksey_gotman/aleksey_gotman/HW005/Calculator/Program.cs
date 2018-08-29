using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc.Plus(2.2, 3.3));
            Console.WriteLine(Calc.Minus(3.3, 2.2));
            Console.WriteLine(Calc.Myltiply(2.2, 3.3));
            Console.WriteLine(Calc.Divide(3.3, 2.2));
            Console.WriteLine(Calc.SquareRoot(9));
            Console.WriteLine(Calc.Square(3));
            Console.WriteLine(Calc.Power(2, 2));
            Console.ReadLine();
        }
    }
}
