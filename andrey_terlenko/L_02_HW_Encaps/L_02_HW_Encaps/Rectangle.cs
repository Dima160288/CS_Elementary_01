using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_02_HW_Encaps
{
    class Rectangle
    {
        private double side_1;
        private double side_2;

        public double Area
        {
            get
            {
                return AreaCalculator(side_1, side_2);
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator(side_1, side_2);
            }
        }

        public Rectangle(double side_1, double side_2)
        {
            if (side_1 < 0 || side_2 < 0)
            {
                throw new ArgumentOutOfRangeException("Sides must be > 0.");
            }
            this.side_1 = side_1;
            this.side_2 = side_2;
        }

        private double AreaCalculator(double side_1, double side_2)
        {
            return side_1 * side_2;
        }

        private double PerimeterCalculator(double side_1, double side_2)
        {
            return (2 * side_1) + (2 * side_2);
        }
    }
}
