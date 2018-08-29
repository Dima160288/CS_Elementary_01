using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_dec_counter
{
    internal class DecimalCounter
    {
        private int counterValue;

        public int CounterValue { get => counterValue; }

        public DecimalCounter()
        {
            counterValue = 10;
        }

        public DecimalCounter(int counterValue)
        {
            this.counterValue = counterValue;
        }

        public void Increase()
        {
            counterValue++;
        }

        public void Decrease()
        {
            counterValue--;
        }

        public void FillRand(int minValue, int maxValue)
        {
            Random rand = new Random();
            counterValue = rand.Next(minValue, maxValue);
        }
    }
}
