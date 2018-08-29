using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstfigure = new Rectangle();
            firstfigure.Getvalue();
            firstfigure.AreaCalculator();
            firstfigure.PerimeterCalculator();


            Console.ReadKey();
        }
    }
}
