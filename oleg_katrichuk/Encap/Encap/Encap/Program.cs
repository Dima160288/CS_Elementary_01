using System;

namespace Encap
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter side 1 : ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2 : ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rect = new Rectangle(side1, side2);

            Console.WriteLine("Area is : {0} ", rect.Area);
            Console.WriteLine("Perimeter is : {0}", rect.Perimeter);

            Console.ReadLine();
        }
    }
}
