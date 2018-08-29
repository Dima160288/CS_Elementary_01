using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    /*16.	Создать абстрактный класс Figure с методами вычисления площади и периметра, а также методом, выводящим информацию о фигуре на экран. Создать производные классы: Rectangle (прямоугольник), Circle (круг), Triangle (треугольник) со своими методами вычисления площади и периметра.Создать массив n фигур и вывести полную информацию о фигурах на экран.*/
    public static class T16
    {

    }
    public abstract class Shape
    {
        public abstract void Area();
        public abstract void Perimeter();
        public abstract void Show();
    }
    public class Rectangle : Shape
    {
        public int A { get; }
        public int B { get; }

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public override void Area()
        {
            Console.WriteLine("Area is {0}", A * B);
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimetr is {0}", 2 * A + 2 * B);
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle: A={0}, B={1}");
        }
    }
    public class Triangle : Shape
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override void Area()
        {
            double p = (A + B + C) / 2;
            Console.WriteLine("Area is {0}", Math.Sqrt(p * (p - A) * (p - B) * (p - C)));
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimetr is {0}", A + B+ C);
        }

        public override void Show()
        {
            Console.WriteLine("Triangle: A={0}, B={1}, C={2}", A, B, C);
        }
    }
    public class Circle : Shape
    {
        public int R { get; }
        public Circle(int r)
        {
            R = r;
        }

        public override void Area()
        {
            Console.WriteLine("Area is {0}", Math.PI*Math.Pow(R,2));
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimetr is {0}", 2 * Math.PI * R);
        }

        public override void Show()
        {
            Console.WriteLine("Circle: R={0}", R);
        }
    }

}
