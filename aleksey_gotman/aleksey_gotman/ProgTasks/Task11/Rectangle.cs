using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class Rectangle
    {
        private Point[] figure = new Point[4];
        private Point a;
        private Point b;
        private Point c;
        private Point d;
        public Point A { get { return a; } }
        public Point B { get { return b; } }
        public Point C { get { return c; } }
        public Point D { get { return d; } }
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            if (x2 < x1 || y2 < y1 || x1 == x2 || y1 == y2)
            {
                Console.WriteLine("Wrong coordinate;");
                a = new Point(0, 0);
                b = new Point(1, 0);
                c = new Point(1, 1);
                d = new Point(0, 1);

            }
            else
            {
                a = new Point(x1, y1);
                b = new Point(x2, y1);
                c = new Point(x2, y2);
                d = new Point(x1, y2);
            }
        }
        public void MoveX(int range)
        {
            a.MoveX(range);
            b.MoveX(range);
            c.MoveX(range);
            d.MoveX(range);
        }
        public void MoveY(int range)
        {
            a.MoveY(range);
            b.MoveY(range);
            c.MoveY(range);
            d.MoveY(range);

        }
        public void Show()
        {
            Console.Write("A ");
            a.Show();
            Console.Write("B ");
            b.Show();
            Console.Write("C ");
            c.Show();
            Console.Write("D ");
            d.Show();
        }
        public void ResizeX(int range)
        {
            b.MoveX(range);
            c.MoveX(range);
        }
        public void ResizeY(int range)
        {
            d.MoveY(range);
            c.MoveY(range);
        }
    }
    public struct Point
    {
        private int x;
        private int y;
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveX(int range)
        {
            x += range;
        }
        public void MoveY(int range)
        {
            y += range;
        }
        public void Show()
        {
            Console.WriteLine("({0},{1})", x, y);
        }
    }
}
