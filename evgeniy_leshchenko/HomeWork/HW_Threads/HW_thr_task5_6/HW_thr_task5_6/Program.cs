using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_thr_task5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }







    }
}


//static void Main()
//{
//    Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

//   

//    // Выполнение метода Method в отдельном потоке, взятом из пула потоков.
//   
//    Console.WriteLine("Main");
//    // Delay.
//    for (int i = 0; i < 80; i++)
//    {
//        Thread.Sleep(50);
//        Console.Write(".");
//    }
//    Console.ReadKey();
//}

//// Метод для выполнения в отдельном потоке.
//static void Method()
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("\nАсинхронный метод запущен.");
//    Console.WriteLine("\nВторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

//    for (int i = 0; i < 80; i++)
//    {
//        Thread.Sleep(60);
//        Console.Write("A");
//    }

//    Console.WriteLine("Асинхронная операция завершена.\n");
//    Console.ForegroundColor = ConsoleColor.Gray;
//}
//    }