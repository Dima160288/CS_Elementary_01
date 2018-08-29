using System;

namespace Zadacha3
{
    class Program
    {
        public static Point[] arrayPoints;


        static void Main(string[] args)
        {
            double lengside = 0;
            Figure f1 = new Figure();

            int kolPoints;

            Console.WriteLine("Введите введите количество точек фигуры от 3 до 5 (int)");
            kolPoints = int.Parse(Console.ReadLine());
            arrayPoints = new Point[kolPoints];
            for (int i = 0; i < kolPoints; i++)
            {
                Console.WriteLine("Введите координаты и название  {0}  точки в формате (int)(int)(string)", i + 1);
                Point A = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), Console.ReadLine());
                arrayPoints[i] = A;
            }




            int figureId = arrayPoints.Length;

            switch (figureId)
            {
                case 3:
                    Console.WriteLine("Фигура является треугольником");
                     f1 = new Figure(arrayPoints[0], arrayPoints[1], arrayPoints[2]);
                    break;
                case 4:
                    Console.WriteLine("Фигура является четырехугольником");
                    f1 = new Figure(arrayPoints[0], arrayPoints[1], arrayPoints[2], arrayPoints[3]);
                    break;
                case 5:
                    Console.WriteLine("Фигура является пятиугольником");
                    f1 = new Figure(arrayPoints[0], arrayPoints[1], arrayPoints[2], arrayPoints[3], arrayPoints[4]);
                    break;
            }

            Console.WriteLine("Введите номера двух точек между которыми требуется определить расстояние");

            lengside = f1.LengthSide(arrayPoints[int.Parse(Console.ReadLine())-1], arrayPoints[int.Parse(Console.ReadLine())-1]);
            Console.WriteLine("Длинна стороны многоугольника равна {0}",lengside);
            f1.PerimeterCalculator();
        }
    }
}
