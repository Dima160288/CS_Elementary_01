using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Constructors
{
    class Point
    {
        // Поля.
        private int x, y;

        // Свойства.
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        // Конструктор по умолчанию, инициализирует поля значениями по умолчанию.
        public Point()
        {
            Console.WriteLine("Конструктор по умолчанию!");
        }

        // Пользовательский конструктор, инициализирует поля значениями заданными пользователем.
        public Point(int x, int y)
        {
            Console.WriteLine("Пользовательский конструктор!");
            this.x = x;
            this.y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Применяем конструктор по умолчанию.
            Point pointA = new Point();
            Console.WriteLine("pointA.X = {0} pointA.Y = {1}", pointA.X, pointA.Y);

            Console.WriteLine(new string('-', 30));

            // Применяем конструктор с параметрами.
            Point pointB = new Point(300, 550);
            Console.WriteLine("pointB.X = {0} pointB.Y = {1}", pointB.X, pointB.Y);

            Console.ReadLine();
        }
    }
}
