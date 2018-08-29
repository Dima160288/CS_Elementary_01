using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_figures
{
    class Rectangle : Figure
    {
        private double a;
        private double b;

        public double A { get => a; }
        public double B { get => b; }

        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentOutOfRangeException("Error: sides can't be <= 0");
            }
            else
            {
                this.a = a;
                this.b = b;
            }            
        }

        public override double Perimeter()
        {
            return Math.Round((2 * a) + (2 * b), 2);
        }

        public override double Area()
        {
            return Math.Round(a * b, 2);
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle:");
            Console.WriteLine($"Side a = {a} cm");
            Console.WriteLine($"Side b = {b} cm");
            Console.WriteLine($"Perimeter = {Perimeter()} cm");
            Console.WriteLine($"Area = {Area()} sq cm");
        }
    }
}
