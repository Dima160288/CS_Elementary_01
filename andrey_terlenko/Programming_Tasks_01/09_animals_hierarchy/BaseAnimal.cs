using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_animals_hierarchy
{
    abstract class BaseAnimal
    {
        private string species;
        private string name;
        private double weight;
        private double activityRatio;
        private double foodAmount;

        public string Species { get => species; }
        public string Name { get => name; }
        public double Weight { get => weight; }
        public double ActivityRatio { get => activityRatio; }
        public double FoodAmount { get => foodAmount; set => foodAmount = value; }

        public BaseAnimal(string species, string name, double weight, double activityRatio)
        {
            this.species = species;
            this.name = name;
            this.weight = weight;
            this.activityRatio = activityRatio;
        }

        public abstract void CalcFoodAmount();
    }
}
