using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Enemies.Shoot
{
    public class SimpleShoot : IShooting
    {
        public void Shoot()
        {
            Console.WriteLine("Shoot");
        }
    }
}
