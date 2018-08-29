using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW002_2
{
    /*Создать класс с именем Rectangle.

В теле класса создать два поля, описывающие длины сторон double side1, side2.

Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.

Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().

Создать два свойства double Area и double Perimeter с одним методом доступа get.

Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.

Инкапсулировать данные*/

    public class Rectangle
    {
        private double side1;
        private double side2;
        public double Area { get; private set; }
        public double Perimetr { get; private set; }

        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public double AreaCalculator()
        {
            Area = side1 * side2;
            return Area;
        }
        public double PerimeterCalculator()
        {
            Perimetr = side1 * 2 + side2 * 2;
            return Perimetr;
        }

    }
}
