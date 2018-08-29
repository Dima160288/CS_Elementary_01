using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_figures
{
    class Circle : Figure
    {
        private double radius;

        public double Radius { get => radius; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Error: radius can't be <= 0");
            }
            else
            {
                this.radius = radius;
            }            
        }

        public override double Perimeter()
        {
            return Math.Round(2 * Math.PI * radius, 2);
        }

        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public override void Show()
        {
            Console.WriteLine("Circle:");
            Console.WriteLine($"Radius = {radius} cm");
            Console.WriteLine($"Perimeter (Length) = {Perimeter()} cm");
            Console.WriteLine($"Area = {Area()} sq cm");
        }
    }
}
