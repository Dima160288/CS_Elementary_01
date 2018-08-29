using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. персонаж
//1.1. Игрок
//1.2. NPC
//1.1.1 Бот
//1.1.2 Донатер
//1.1.3 обычный игрок

//1.2.1 статический npc
//1.2.2 квестовій npc

//....

namespace CW04
{
    class Character
    {
       protected  int CharacterID;
       protected string CharacterName; 
        
    }

    class NPC : Character
    {
        int ScriptID; // скрипты
    }

    class Player : Character
    {

    }

    class StandartPlayer : Player
    {

    }

    class DonatePlayer : Player
    {

    }

    class botPlayer : Player
    {

    }

    class StaticNPC : NPC
    {

    }

    class QuestNPC : NPC
    {

    }

    class Items : Character
    {

    }

    class Armor : Items
    {

    }

    class Weapon : Items
    {

    }

    class MeleeWeapon : Weapon
    {

    }

    class RangeWeapon : Weapon
    {

    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
