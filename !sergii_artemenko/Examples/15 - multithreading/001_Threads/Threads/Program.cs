using System;
using System.Threading;

// Потоки.

namespace Threads
{
    class Program
    {
        // Метод, который планируется выполнять в отдельном потоке.
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 10) + "Secondary");
                Thread.Sleep(10);
            }
        }

        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            while (true)
            {
                Console.WriteLine("Primary");
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
