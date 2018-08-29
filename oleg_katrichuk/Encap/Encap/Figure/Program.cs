using System;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {

            Point point1 = new Point(0, 0);
            Point point2 = new Point(1, 1);
            Point point3 = new Point(2, 2);
            Point point4 = new Point(3, 3);
            Point point5 = new Point(4, 4);

            Figure figure = new Figure(point1, point2, point3);
            Console.Write(figure.Name);
            Console.WriteLine(" Perimeter is " + figure.PerimeterCalculator());

            Figure figure1 = new Figure(point1, point2, point3, point4);
            Console.Write(figure1.Name);
            Console.WriteLine(" Perimeter is " + figure1.PerimeterCalculator());

            Figure figure2 = new Figure(point1, point2, point3, point4, point5);
            Console.Write(figure2.Name);
            Console.WriteLine(" Perimeter is " + figure2.PerimeterCalculator());

            Console.ReadKey();
        }
    }
}
