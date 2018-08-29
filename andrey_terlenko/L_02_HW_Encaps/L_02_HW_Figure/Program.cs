using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_02_HW_Figure
{
    class Program
    {
        public Figure figure;        

        static void Main(string[] args)
        {
            Figure figure = new Figure();

            Console.Write("Enter number of points (from 3 to 5): ");
            int numpoints = int.Parse(Console.ReadLine());

            Point[] pointsArr = new Point[numpoints];

            for (int i = 0; i < pointsArr.Length; i++)
            {
                int x, y;
                string name;
                Console.Write("Enter coord X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter coord Y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Enter name of point: ");
                name = Console.ReadLine();
                Point point = new Point(x, y, name);
                pointsArr[i] = point;
            }

            switch (pointsArr.Length)
            {
                case 3:
                    figure = new Figure(pointsArr[0], pointsArr[1], pointsArr[2]);
                    break;
                case 4:
                    figure = new Figure(pointsArr[0], pointsArr[1], pointsArr[2], pointsArr[3]);
                    break;
                case 5:
                    figure = new Figure(pointsArr[0], pointsArr[1], pointsArr[2], pointsArr[3], pointsArr[4]);
                    break;
                default:
                    Console.WriteLine("Incorrect data");
                    break;
            }

            Console.Write("Enter index of el 1: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter index of el 2: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Length of side: ");
            Console.WriteLine(figure.LengthSide(pointsArr[A], pointsArr[B]));
            figure.PerimeterCalculator();
        }
    }
}
