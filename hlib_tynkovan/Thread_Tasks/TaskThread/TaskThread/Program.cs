using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskThread
{
    class Program
    {
        static void Prog(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new Thread(Prog);
            t.Name = "Thread " + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }
        private static void Main(string[] args)
        {
            Prog(5);
            Console.ReadKey();
        }
    }
}
