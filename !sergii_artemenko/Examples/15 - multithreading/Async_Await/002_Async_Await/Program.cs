using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_Async_Await
{
    class MyClass
    {
        public void Operation()
        {
            Console.WriteLine("Operation ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Begin");
            Thread.Sleep(2000);
            Console.WriteLine("End");
        }

        public async void OperationAsync()
        {
            // ID потока совпадает с ID первичного потока. Это значит, что
            // данный метод начинает выполнятся в контексте первичного потока
            Console.WriteLine("OperationAsync (Part 1) ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            Task task = new Task(Operation);
            task.Start();
            await task;

            // ID потока совпадает с ID вторичного потока. Это значит, что
            // данный метод заканчивает выполнятся в контексте вторичного потока
            Console.WriteLine("OperationAsync (Part 2) ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            MyClass my = new MyClass();
            my.OperationAsync();
            Console.WriteLine("Main ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }
    }
}
