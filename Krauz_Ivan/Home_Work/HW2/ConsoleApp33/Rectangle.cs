using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle ()
        {

        }
        
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public void Getvalue ()
        {
            Console.WriteLine("Enter Side1");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Side2");
            Side2 = Convert.ToDouble(Console.ReadLine());

        }

        public void AreaCalculator()
        {
            Console.WriteLine(Side1 * Side2);
        }

        public void PerimeterCalculator()
        {
            Console.WriteLine((Side1 + Side2) * 2);
        }
    }
}
