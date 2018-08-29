using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Point
    {
        private string name;
        private int x, y;

        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Введите букву точки:");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите X точки:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y точки:");
            this.y = int.Parse(Console.ReadLine());
        }
    }

    class Figure
    {
        private int number;
        Point[] points;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("Введите количество точек фигуры ");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }

        public Figure(string name)
        {
            InitializeFigure();
        }

        public void DefineName()
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Такой фигуры нет, это просто точка");
                    break;
                case 2:
                    Console.WriteLine("Это не фигура, а прямая");
                    break;
                case 3:
                    Console.WriteLine("Эта фигура - треугольник");
                    break;
                case 4:
                    Console.WriteLine("Эта фигура - четырехугольник");
                    break;
                case 5:
                    Console.WriteLine("Эта фигура - пятиугольник");
                    break;
                case 6:
                    Console.WriteLine("Эта фигура - шестиугольник");
                    break;
                case 7:
                    Console.WriteLine("Эта фигура - семиугольник");
                    break;
                case 8:
                    Console.WriteLine("Эта фигура - восьмиугольник");
                    break;
            }

            if (number >=9)
                Console.WriteLine("зачем Вам фигура, у которой больше 8 вершин, я хз как она зовется, но периметр вот.)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
                Figure figure = new Figure("Фигура");
                figure.DefineName();
                Console.WriteLine(figure.CalculatePerimeter());
                Console.ReadKey();
        }
    }
}
