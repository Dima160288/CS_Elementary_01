using System;


namespace Rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;


        public double Side1
        {
            get { return side1; }
        }

        public double Side2
        {
            get { return side2; }
        }

        public double AreaCalculator(double Side1, double Side2)
        {
            return Side1 * Side2;
        }

        public double PerimeterCalculator(double Side1, double Side2)
        {
            return (side1 * 2) + (side2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine(rect.AreaCalculator(2, 3));
            Console.WriteLine(rect.PerimeterCalculator(2, 3));
            Console.ReadLine();
        }
    }
}
