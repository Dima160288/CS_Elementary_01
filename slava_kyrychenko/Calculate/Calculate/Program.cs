using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Go();
        }
    }

    static class Calculator
    {
       static public bool quit;

        public static void Go()
        {
            double a = 0;
            double b = 0;
            char simb = ' ';
            do
            {
                Console.WriteLine("Введите первое число -->");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число -->");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите арифметическую операцию '+' , '-' , '*' , '/' Либо 'q' для выхода -->");
                simb = Convert.ToChar(Console.ReadLine());

                switch (simb)
                {
                    case '+': Console.WriteLine(" {0} {1} {2} = {3}  ",a,simb,b,(a+b)); break;
                    case '-': Console.WriteLine(" {0} {1} {2} = {3}  ", a, simb, b, (a - b)); break;
                    case '*': Console.WriteLine(" {0} {1} {2} = {3}  ", a, simb, b, (a * b)); break;
                    case '/': Console.WriteLine(" {0} {1} {2} = {3}  ", a, simb, b, (a / b)); break;
                    case 'q': { Console.WriteLine(" Good bye  "); quit = true; } break;
                    default: { Console.WriteLine("Не корректный ввод б читайте инструкцию"); Instructions(); } break;
                }
            }

            while (!quit);
        }

        public static void Instructions()
        {
            Console.WriteLine("Введите первое число типа double ");
            Console.WriteLine("Введите второе число типа double");
            Console.WriteLine("Введите орифметическую опирацию '+' , '-' , '*' , '/' ");
        }
    }
}
