using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace cw_4_thread
{
    class Program
    {
       static int FlagStop = 0;

        private static Mutex mutex = new Mutex();

        static void Main()
        {
            //for (int i = 0; i < 5; i++)
            //{
                Thread thread = new Thread(new ThreadStart(TestMethod));
                thread.Start(); 
            //     thread.Name = String.Format("Поток {0}", i + 1);

            //  }

            // Задержка.
            Console.ReadKey();
        }

        private static void TestMethod()
        {
            FlagStop += 1;
            if (FlagStop == 500) { return; }

           // mutex.WaitOne();

            Console.WriteLine("Метод запущен в потоке:" + Thread.CurrentThread.ManagedThreadId);
            Thread thread = new Thread(new ThreadStart(TestMethod));
            thread.Start();
            thread.Join();
            Thread.Sleep(1000);
            
           // mutex.ReleaseMutex();
            Console.WriteLine("Метод закрывается в потоке:" + Thread.CurrentThread.ManagedThreadId);
        }

        // Данный метод представляет собой ресурс, который должен быть синхронизирован так,
        // что только один поток может его выполнять в одно время.
        //private static void UseResource()
        //{
        //    // Метод WaitOne используется для запроса на владение мьютексом.
        //    // Блокирует текущий поток.
           

        //    Console.WriteLine("{0} вошел в защищенную область.", Thread.CurrentThread.Name);
        //    Thread.Sleep(1000); // Выполнение некоторой работы...
        //    Console.WriteLine("{0} покидает защищенную область.\r\n", Thread.CurrentThread.Name);

        //    mutex.ReleaseMutex();  // Освобождение Mutex.

        //    Thread.Sleep(1000); // Выполнение некоторой работы...
        //}
    }
}




