using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_incapsulation
{
    class Rectangle
    {
        //cоздать класс с именем Rectangle.
        //В теле класса создать два поля, описывающие длины сторон double side1, side2.
        //Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
        //Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
        //Создать два свойства double Area и double Perimeter с одним методом доступа get.
        //Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
        //Инкапсулировать данные
        private double side1, side2;
        private double area;
        public double Area
        {
            get
            {
                return area;
            }
        }

        private double perimeter;
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            area = side1 * side2;
            return Area;
        }

        private double PerimeterCalculator()
        {
            perimeter = (side1 + side2) * 2;
            return Perimeter;
        }

        public void Display()
        {
            AreaCalculator();
            PerimeterCalculator();
            Console.WriteLine($"Площадь: {Area}, Периметр: {Perimeter}");
        }
    }
}
