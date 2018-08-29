using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Figure
{
    class Figure
    {
        public List<Point> Points { get; }
        public string Name { get; protected set; }
        public Figure(Point p1, Point p2, Point p3)
        {
            Points = new List<Point>() { p1, p2, p3 };
            
               Name = "Треугольник";
            
        }
        public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3)
        {
            Points.Add(p4);
            Name = "Квадрат";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3, p4)
        {
            Points.Add(p5);
            Name = "Пятиугольник";
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.Y, 2) + Math.Pow(a.X - b.X, 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0.0;
            var i = 0;
            while (i + 1 < Points.Count)
            {
                perimeter += LengthSide(Points[i], Points[i + 1]);
                i++;
            }
            perimeter += LengthSide(Points[i], Points[0]);
            return perimeter;
        }
    }
}
