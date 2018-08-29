using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_6
{
    class Program
    {
        static void Main()
        {
            int i = 2;

            var myDelegate = new Action<int>(Method);

            var callback = new AsyncCallback(HandleCompletion);

            myDelegate.BeginInvoke(i, callback, i);

            Console.WriteLine("Первичный поток продолжает работать.");

            Console.ReadKey();
        }

        // Метод для выполнения в отдельном потоке.
        static void Method(int StartPoint)
        {
            
            Console.WriteLine("\nАсинхронный метод запущен.");

            while(StartPoint < 10000000)
            {
                StartPoint = StartPoint * 2;
                Thread.Sleep(50);
            }

            Console.WriteLine("Асинхронная операция завершена.\nЗначение после операции: "+ StartPoint);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Callback метод для обработки завершения асинхронной операции.
        static void HandleCompletion(IAsyncResult asyncResult)
        {
            Console.WriteLine("Стартовое значение было: " + asyncResult.AsyncState);
        }

    }
}
