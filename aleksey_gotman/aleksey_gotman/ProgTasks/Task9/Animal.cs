using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public abstract class Animal
    {
        protected string kind;
        protected string name;
        protected int weight;
        protected double ratioActivity;
        protected double amountFood;
        public string Kind { get { return kind; } }
        public string Name { get { return name; } }
        public int Weight { get { return weight; } }
        public double RatioActivity { get { return ratioActivity; } }
        public double AmountFood { get { return amountFood; } }
        public abstract void AmountOfFood();
        public Animal(string kind, string name, int weight, double ratioActivity)
        {
            this.kind = kind;
            this.name = name;
            this.weight = weight;
            this.ratioActivity = ratioActivity;
        }
    }
}
