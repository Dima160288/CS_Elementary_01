using Strategy.Enemies.Run;
using Strategy.Enemies.Shoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Enemies
{
    public abstract class SoldierBase
    {
        protected IRunning running;
        protected IShooting shooting;

        public SoldierBase()
        {
            running = new SimpleRun();
            shooting = new SimpleShoot();
        }

        public void Run() { running.Run(); }

        public void Shoot() { shooting.Shoot(); }

        // 2
        public void PeelPotatoes() { Console.WriteLine("I'm peeling potatoes!"); }

        public abstract void Display();
    }
}
