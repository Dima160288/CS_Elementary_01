using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_02_HW_Figure
{
    class Figure
    {
        public Point Point_B;
        public Point Point_A;
        public Point Point_C;
        public Point Point_D;
        public Point Point_E;

        private Point[] figures;
        private string name;

        public string Name
        {
            get
            {
                foreach(Point el in figures)
                {
                    name += el.Name;
                }
                return name;
            }
        }

        public Figure()
        {

        }

        public Figure(Point A, Point B, Point C)
        {
            Point_A = A;
            Point_B = B;
            Point_C = C;
            figures = new Point[3] { A, B, C };
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            Point_A = A;
            Point_B = B;
            Point_C = C;
            Point_D = D;
            figures = new Point[4] { A, B, C, D };
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            Point_A = A;
            Point_B = B;
            Point_C = C;
            Point_D = D;
            Point_E = E;
            figures = new Point[5] { A, B, C, D, E };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < figures.Length - 1; i++)
            {
                if (i == 0)
                {
                    perimeter += LengthSide(figures[figures.Length - 1], figures[0]);
                }
                perimeter += LengthSide(figures[i], figures[i + 1]);
            }
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}
