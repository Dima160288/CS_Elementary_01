using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    /*15.	Описать класс, представляющий треугольник. Предусмотреть методы для создания объектов, вычисления площади, периметра и точки пересечения медиан. Описать свойства для получения состояния объекта.*/
    public class T15
    {

    }
    public class Triangle
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        double a;
        double b;
        double c;
        public Triangle(int ax, int ay, int bx, int by, int cx, int cy)
        {
            A = new Point(ax, ay);
            B = new Point(bx, by);
            C = new Point(cx, cy);
            CalcSide();
        }
        void CalcSide()
        {
            a = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            b = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
            c = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
        }
        public void Show()
        {
            Console.WriteLine("A " + A.Show());
            Console.WriteLine("B " + B.Show());
            Console.WriteLine("C " + C.Show());
            Console.WriteLine("Triangle a:{0}, b:{1}, c:{2}", a, b, c);
        }
        public void Area()
        {
            double p = (a + b + c) / 2;
            Console.WriteLine("Area is {0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimetr is {0}", a + b + c);
        }
        public void IntersectionOfMedian()
        {
            Point p = new Point((A.X + B.X + C.X) / 3, (A.Y + B.Y + C.Y) / 3);
            Console.WriteLine("Point intersection of median is {0}", p.Show());
        }
    }
    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
        public string Show()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}
