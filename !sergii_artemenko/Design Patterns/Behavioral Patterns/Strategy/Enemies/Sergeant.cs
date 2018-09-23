using Strategy.Enemies.Shoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Enemies
{
    class Sergeant : SoldierBase
    {
        public Sergeant()
        {
            shooting = new NoShoot();
        }

        public override void Display()
        {
            Console.WriteLine("Hi, I'm a Sergeant");
        }
    }
}
