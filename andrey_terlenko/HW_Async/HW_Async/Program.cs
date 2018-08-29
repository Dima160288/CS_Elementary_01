using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW_Async
{
    class Program
    {
        delegate int MyDelegate(int num1, int num2);

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void AddCompletion(IAsyncResult asyncResult)
        {
            Console.WriteLine("Start of callback method");
            string result = (string)asyncResult.AsyncState;
            Console.WriteLine("Before: " + result);
            result += " 12345";
            Console.WriteLine("After: " + result);
            Console.WriteLine("End of callback method");
        }

        static void Main(string[] args)
        {
            MyDelegate my = new MyDelegate(Add);
            AsyncCallback callback = new AsyncCallback(AddCompletion);
            IAsyncResult result = my.BeginInvoke(10, 20, callback, "qwerty");
            int res = my.EndInvoke(result);
            Console.WriteLine("10 + 20 = " + res);
            Thread.Sleep(1000);
        }
    }
}
