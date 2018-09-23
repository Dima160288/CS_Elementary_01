using Strategy.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// При использовании наследования некоторые классы наследуют ненужный функционал
// При использовании интерфейсов необходимо повторно реализовывать один и тот-же код во всех классах
// Проблема дальнейшего сопровождения программы
// ИЗМИНЕНИЯ - главный враг проектирования

// Отделить изминяющиеся части приложения от тех, которые изменятся не будут,
// и объеденить их в отдельный аспект
// Надо программировать на уровне интерфейсов, а не на уровне реализаций

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SoldierBase> enemies = new List<SoldierBase>();
            enemies.Add(new Soldier1());
            enemies.Add(new Soldier2());
            enemies.Add(new General());
            enemies.Add(new Sergeant());

            foreach (var enemy in enemies)
            {
                enemy.Display();

                //if(enemy is IRunning)
                //    (enemy as IRunning).Run();

                //if(enemy is IShooting)
                //    (enemy as IShooting).Shoot();
                enemy.Run();
                enemy.Shoot();
                enemy.PeelPotatoes();
                Console.WriteLine(new string('-', 30));
            }

            Console.ReadLine();
        }
    }
}
