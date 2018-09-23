using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Enemies.Run
{
    public class SimpleRun : IRunning
    {
        public void Run()
        {
            Console.WriteLine("Run");
        }
    }
}
