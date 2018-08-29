using System;
using System.Collections.Generic;
using System.Text;

namespace Encap
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public double Area { get; }
        public double Perimeter { get; }
        public Rectangle()
        {

        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }

        public double AreaCalculator()
        {
            return side1 * side2;

        }

        public double PerimeterCalculator()
        {
            return 2 * (side2 + side1);
        }


    }
}
