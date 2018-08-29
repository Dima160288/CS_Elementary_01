using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struct
{
    struct Point
    {
        // 1
        public int x;
        public int y;

        //// 2
        //public void Show()
        //{
        //    Console.WriteLine("{0}, {1}", x, y);
        //}

        //// 4 пользовательский конструктор
        //public Point(int x, int y)
        //{
        //    this.x = x;
        //    this.y = y; // Закоментировать!
        //}


    }

    class Program
    {
        static Point staticPoint;
        Point dynamicPoint;

        static void Main(string[] args)
        {
            //1
            Point point;
            point.x = 10;

            staticPoint.x = 10;

            Point[] points = new Point[10];
            points[0].x = 10;

            var instance = new Program();
            instance.dynamicPoint.x = 10;

            // 2
            //Point point;
            //point.x = 10;
            ////point.y = 10;
            //Console.WriteLine(point.x);
            ////Console.WriteLine(point.Y); //ошибка компиляции, point.Y не инициализировано
            ////point.Show(); //ошибка компиляции, point не инициализирован в целом

            // 3
            //Point point = new Point();
            //Console.WriteLine("{0}, {1}", point.x, point.y);
            //point.Show();

            //// 4
            //Point point = new Point(10, 20);
            //point.Show();

            Console.ReadLine();

        }
    }
}
