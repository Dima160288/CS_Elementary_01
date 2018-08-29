using System;

// Анонимные (лямбда) методы.

namespace Delegates
{
    // Создаем класс делегата.
    public delegate void MyDelegate(ref int a, ref int b, out int c);

    public delegate int NewDelegate( int a, int b, int c);

    class Program
    {
        static void Main()
        {
            int summand1 = 1, summand2 = 2, sum;

            MyDelegate myDelegate = delegate(ref int a, ref int b, out int c) { a++; b++; c = a + b; };

            myDelegate(ref summand1, ref summand2, out sum);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            NewDelegate newDelegate = delegate(int a, int b, int c) { return (a + b + c) / 2; };
            Console.WriteLine(newDelegate(2, 3, 4));

            // Delay.
            Console.ReadKey();
        }



    }
}
