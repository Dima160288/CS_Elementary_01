using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005_Async_Await_Continuation
{
    class MyClass
    {
        public void Operation()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Основная задача");
        }

        public async Task OperationAsync()
        {
            // return указывать не нужно, так как await сформирует return (неявно) самостоятельно
            await Task.Factory.StartNew(Operation);
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            Task task = my.OperationAsync();

            task.ContinueWith(t => { Thread.Sleep(4000); Console.WriteLine("\nПродолжение задачи."); });

            Console.ReadLine();
        }
    }
}
