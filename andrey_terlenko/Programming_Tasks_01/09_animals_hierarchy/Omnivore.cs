using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_animals_hierarchy
{
    class Omnivore : BaseAnimal
    {
        private const double speciesRatio = 0.15;

        public Omnivore(string species, string name, double weight, double activityRatio) : base(species, name, weight, activityRatio)
        {
        }

        public override void CalcFoodAmount()
        {
            FoodAmount = Weight * ActivityRatio * speciesRatio;
        }
    }
}
