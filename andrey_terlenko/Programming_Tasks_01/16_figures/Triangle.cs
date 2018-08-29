using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_figures
{
    class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public double A { get => a; }
        public double B { get => b; }
        public double C { get => c; }

        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Error: sides can't be <= 0");
            }
            if ((a > b + c) || (a < b - c) || (b > a + c) || (b < a - c) || (c > a + b) || (c < a - b))
            {
                throw new Exception("Error: any side of triangle must be less than sum of other two and greater than subtraction difference of other two");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public override double Perimeter()
        {
            return Math.Round(a + b + c, 2);
        }

        public override double Area()
        {
            double p = Perimeter() / 2; //half of perimeter
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }

        public override void Show()
        {
            Console.WriteLine("Triangle:");
            Console.WriteLine($"Side a = {a} cm");
            Console.WriteLine($"Side b = {b} cm");
            Console.WriteLine($"Side c = {c} cm");
            Console.WriteLine($"Perimeter = {Perimeter()} cm");
            Console.WriteLine($"Area = {Area()} sq cm");
        }
    }
}
