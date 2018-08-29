using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        private double side1, side2;
         
        public double Side1
        {
            get
            {
                return side1;
            }
         }

        public double Side2
        {
            get
            {
                return side2;
            }
        }   

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimetrCalculator()
        {
            return (side1 + side2) * 2;
        }
    }
}
