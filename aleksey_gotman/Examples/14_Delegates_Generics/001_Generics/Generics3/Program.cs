using System;
using System.Threading;

// Универсальные шаблоны. (Универсальный метод)

namespace Generics
{
    class MyClass
    {
        public void Method<T>(T argument)
        {
            T variable = argument;

            Console.WriteLine(variable);
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                instance.Method<string>("Hello world!");


                instance.Method("Привет мир!");
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
