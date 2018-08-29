using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1 -
//Создать класс с именем Rectangle.
//В теле класса создать два поля, описывающие длины сторон double side1, side2.
//Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2
//    инициализируются значениями аргументов.
//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника
//    - double PerimeterCalculator().
//Создать два свойства double Area и double Perimeter с одним методом доступа get.
//Написать программу, которая принимает от пользователя длины двух сторон прямоугольника 
//    и выводит на экран периметр и площадь.
//Инкапсулировать данные

namespace HW_02
{
    class Rectangle
    {
        private double side1; //{ get; set; } в текущем варианте обращаться к ним извне класса мы не будем.
        private double side2; //{ get; set; }

        private double Area { get; }
        private double Perimeter { get; }

        public Rectangle()
        {

        }

        public Rectangle(double Side1, double Side2)
        {
            side1 = Side1;
            side2 = Side2;

            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }


       private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return side1 * 2 +  side2 * 2;
        }

    }
}
