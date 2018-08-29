using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await_ReturnAndArgument
{
    class MyClass
    {
        private double Operation(object arg)
        {
            Thread.Sleep(2000);
            return (double)arg * (double)arg;
        }

        public async Task<double> OperationAsync(double arg)
        {
            return await Task<double>.Factory.StartNew(Operation, arg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            Task<double> task = my.OperationAsync(3);

            task.ContinueWith(t => Console.WriteLine("Result: {0}", t.Result));


            Console.ReadLine();
        }
    }
}
