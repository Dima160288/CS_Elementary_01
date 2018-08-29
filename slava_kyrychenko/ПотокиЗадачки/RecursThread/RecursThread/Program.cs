using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RecursThread
{
    class Program
    {
        public static int countOfThread=0;
        static void Main(string[] args)
        {
            Thread thread = new Thread(Method);
            thread.Start();
        }

       static public void Method()
        {
            Thread thread = new Thread(Method);
            thread.Start();
            countOfThread++;
            Console.WriteLine("Potok {0}",countOfThread);
        }
    }
}
