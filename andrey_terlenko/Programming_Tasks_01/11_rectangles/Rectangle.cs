using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_rectangles
{
    class Rectangle
    {
        Point[] rectangle = new Point[4];
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        public Point A { get => a; }
        public Point B { get => b; }
        public Point C { get => c; }
        public Point D { get => d; }

        public Rectangle(int x_1, int y_1, int x_2, int y_2)
        {
            if (x_2 < x_1 || y_2 < y_1 || x_1 == x_2 || y_1 == y_2)
            {
                Console.WriteLine("Your coordinates are not correct");
            }
            else
            {
                this.a = new Point(x_1, y_1);
                this.b = new Point(x_1, y_2);
                this.c = new Point(x_2, y_2);
                this.d = new Point(x_2, y_1);
            }
        }

        public void MoveX(int offset)
        {
            a.MoveX(offset);
            b.MoveX(offset);
            c.MoveX(offset);
            d.MoveX(offset);
        }

        public void MoveY(int offset)
        {
            a.MoveY(offset);
            b.MoveY(offset);
            c.MoveY(offset);
            d.MoveY(offset);
        }

        public void ResizeX(int offset)
        {
            c.MoveX(offset);
            d.MoveX(offset);
        }

        public void ResizeY(int offset)
        {
            a.MoveY(offset);
            b.MoveY(offset);
        }

        public void Show()
        {
            Console.Write($"A: ");
            a.Show();
            Console.Write($"B: ");
            b.Show();
            Console.Write($"C: ");
            c.Show();
            Console.Write($"D: ");
            d.Show();
        }
    }
}
