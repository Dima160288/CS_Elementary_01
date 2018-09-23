using Strategy.Enemies.Run;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Enemies
{
    class General : SoldierBase
    {
        public General()
        {
            running = new NoRun();
        }
        public override void Display()
        {
            Console.WriteLine("Hi, I'm a General");
        }
    }
}
