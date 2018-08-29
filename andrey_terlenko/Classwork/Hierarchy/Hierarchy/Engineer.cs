using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Engineer : General
    {
        public Engineer(string nickname, int playerLevel, int health)
        {
            this.nickname = nickname;
            this.playerLevel = playerLevel;
            this.health = health;
            hasSMGs = true;
        }

        private bool hasSMGs;

        protected void ChooseSMG()
        { }
    }
}
