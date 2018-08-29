using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class General
    {
        public string nickname { get; set; }
        public int playerLevel { get; set; }
        protected int health { get; set; }
        

        protected void ChooseGrenades()
        { }
        protected void ChooseHandgun()
        { }
        protected void ChooseGatgets()
        { }
        protected void TakeDamage()
        { }
        protected void Heal()
        { }
    }
}
