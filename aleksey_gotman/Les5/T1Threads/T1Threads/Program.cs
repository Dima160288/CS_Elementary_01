using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace T1Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            DoIt();
        }
        public static void IDo()
        {
            Thread t = new Thread(DoIt);
            t.Start();
        }
        public static void DoIt()
        {
            IDo();
        }
    }
}
