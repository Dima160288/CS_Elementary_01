using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Program
    {


        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите длины сторон прямоугольника");

            var rect = new Rectangle(Convert.ToDouble( Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Площадь прямоугольника состовляет : {0},", rect.AreaCalculator());
            Console.WriteLine("Периметр прямоугольника равен {0}", rect.PerimetrCalculator());
        }
    }
}
