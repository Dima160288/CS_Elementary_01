using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Omnivorous : Animal
    {
        private const double ratioKind = 0.15;

        public Omnivorous(string kind, string name, int weight, double ratioActivity) : base(kind, name, weight, ratioActivity)
        {
        }

        public override void AmountOfFood()
        {
            amountFood = weight * ratioActivity * ratioKind;
        }
    }
}
