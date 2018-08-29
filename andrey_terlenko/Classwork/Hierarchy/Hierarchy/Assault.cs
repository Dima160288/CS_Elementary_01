using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Assault : General
    {
        public Assault(string nickname, int playerLevel, int health)
        {
            this.nickname = nickname;
            this.playerLevel = playerLevel;
            this.health = health;
            hasAssaultRifles = true;
        }

        private bool hasAssaultRifles;

        protected void ChooseAssaultRifle()
        { }
    }
}
