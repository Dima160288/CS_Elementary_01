using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Example
{
    
    class Enemy
    {
        private int HealthPower;
        private int Armor;
        private int Endurance;
        private int MoveSpeed;

    }
    class Warior : Enemy
    {
        private int WariorDamage;
        private int WariorArmor;
        private int WariorHealtPower;

    }
    class Tank : Warior
    {

    }

    class DamageDiller : Warior
    {

    }

    class Assasin : Warior
    {

    }

    class Archer : Enemy
    {

    }
    class CommonArrow : Archer
    {

    }

    class FireArrow : Archer
    {

    }

    class PoisonedArrow : Archer
    {

    }


    class Wizzard : Enemy
    {

    }
    class FireMage : Wizzard
    {

    }

    class FrostMage : Wizzard
    {

    }

    class LightningMage : Wizzard
    {

    }
}



