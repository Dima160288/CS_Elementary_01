using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Enemies
{
    class Soldier2 : SoldierBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi, I'm a Soldier 2");
        }
    }
}
