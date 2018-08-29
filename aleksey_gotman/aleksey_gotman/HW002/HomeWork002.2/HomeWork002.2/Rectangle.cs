using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork002._2
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public double Area { get; private set; }
        public double Perimetr { get; private set; }

        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public double AreaCalculator()
        {
            Area = side1 * side2;
            return Area;
        }
        public double PerimeterCalculator()
        {
            Perimetr = side1 * 2 + side2 * 2;
            return Perimetr;
        }

    }
}
