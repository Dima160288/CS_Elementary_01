using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha3
{
    class Figure
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Point Point4 { get; set; }
        public Point Point5 { get; set; }

        public Figure() { }
        public Figure(Point a, Point b, Point c)
        {
            Point1 = a;
            Point2 = b;
            Point3 = c;
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            Point1 = a;
            Point2 = b;
            Point3 = c;
            Point4 = d;
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            Point1 = a;
            Point2 = b;
            Point3 = c;
            Point4 = d;
            Point5 = e;
        }

        public double LengthSide(Point p1, Point p2)
        {
            int a,b = 0;
            a=Math.Abs(p1.X - p2.X);
            b= Math.Abs(p1.Y - p2.Y);
            return Math.Sqrt(a * a + b * b); 
        }

        public void PerimeterCalculator()
        {
            double perimetr=0;
            int a, b = 0;
            for (int i = 0; i < Program.arrayPoints.Length; i ++)
            {
                if (i == Program.arrayPoints.Length-1)
                {
                    a = Math.Abs(Program.arrayPoints[i].X - Program.arrayPoints[0].X);
                    b = Math.Abs(Program.arrayPoints[i].Y - Program.arrayPoints[0].Y);
                }
                else
                {
                    a = Math.Abs(Program.arrayPoints[i].X - Program.arrayPoints[i + 1].X);
                    b = Math.Abs(Program.arrayPoints[i].Y - Program.arrayPoints[i + 1].Y);
                    
                }
                 perimetr += Math.Sqrt(a * a + b * b);
            }
            Console.WriteLine("Периметр многоугольника равен {0}", perimetr);
        } 
    }
}
