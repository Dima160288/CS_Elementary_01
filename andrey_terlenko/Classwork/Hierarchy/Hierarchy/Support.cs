using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Support : General
    {
        public Support(string nickname, int playerLevel, int health)
        {
            this.nickname = nickname;
            this.playerLevel = playerLevel;
            this.health = health;
            hasLMGs = true;
        }

        private bool hasLMGs;

        protected void ChooseLMG()
        { }
    }
}
