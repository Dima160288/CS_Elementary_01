using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Scout : General
    {
        public Scout(string nickname, int playerLevel, int health)
        {
            this.nickname = nickname;
            this.playerLevel = playerLevel;
            this.health = health;
            hasSniperRifles = true;
        }

        private bool hasSniperRifles;

        protected void ChooseSniperRifle()
        { }
    }
}
