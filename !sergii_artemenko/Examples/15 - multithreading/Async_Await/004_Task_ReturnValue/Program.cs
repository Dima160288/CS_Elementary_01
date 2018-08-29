using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _004_Task_ReturnValue
{
    class MyClass
    {
        private int Operation()
        {
            Console.WriteLine("Операция выполняется в потоке {0}", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(2000);

            return 2 + 2;

        }

        // async указывает, что метод является асинхронным
        public async void OperationAsync()
        {
            Task<int> task = Task<int>.Factory.StartNew(Operation);

            // await - ожидание завершения работы асинхронной задачи
            Console.WriteLine("\nРезультат: {0}\n", await task);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.OperationAsync();

            Console.WriteLine("Первичный поток завершил работу. ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }
    }
}
