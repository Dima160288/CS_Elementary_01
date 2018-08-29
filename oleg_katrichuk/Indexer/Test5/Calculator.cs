using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    static class Calculator
    {
        private static double number1;
        private static double number2;

        public static void GetValue()
        {
            Console.Write("Enter number 1 : ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            number2 = Convert.ToDouble(Console.ReadLine());

        }

        public static void Addition()
        {
            Console.WriteLine("Addition is : " + (number1 + number2));
        }

        public static void Subtraction()
        {
            Console.WriteLine("Subtraction is : " + (number1 - number2));
        }

        public static void Multiplication()
        {
            Console.WriteLine("Multiplication is : " + number1 * number2);
        }

        public static void Division()
        {
            Console.WriteLine("Division is : " + number1 / number2);
        }

    }
}
