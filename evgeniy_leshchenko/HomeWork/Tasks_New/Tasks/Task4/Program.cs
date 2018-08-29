using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;

//4.	Описать класс, реализующий десятичный счетчик, который может увеличивать или уменьшать свое значение на единицу 
//    в заданном диапазоне.Предусмотреть инициализацию счетчика значениями по умолчанию и произвольными значениями.
//    Счетчик имеет два метода: увеличения и уменьшения, — и свойство, позволяющее получить его текущее 
//    состояние.Написать программу, демонстрирующую все возможности класса.

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();


            Counter cntr = new Counter(rand.Next(101,1000), rand.Next(0,100), rand.Next(1000,2000));

            Console.WriteLine("Входные данные: \n\nСтартовое значение:" + cntr.Value + "\nДиапазон от " + cntr.MinValue + " до " + cntr.MaxValue);

            cntr.IncValue();
            Console.WriteLine("\nЗначение счетчика после инкримента: " + cntr.Value);
            cntr.DecValue();
            Console.WriteLine("\nЗначение счетчика после декримента: " + cntr.Value);


            Console.ReadKey();
        }
    }

    class Counter
    {
        private int value;
        private int minValue;
        private int maxValue;

        public int Value
        {
            get { return value; }
        }

        public int MinValue
        {
            get { return minValue; }
        }

        public int MaxValue
        {
            get { return maxValue; }
        }

        public Counter()
        {
            value = 0;
            minValue = 0;
            maxValue = 100;
        }


        public Counter(int value, int minValue,int maxValue)
        {
            if(value < minValue || value > maxValue)
            {
                Console.WriteLine("Стартовое значение не попадает в диапазон!");
                return;
            }

            this.value = value;
            this.minValue = minValue;
            this.maxValue = maxValue;
        }


        public void IncValue()
        {
            if (value++ < maxValue)
                value = value++;
            else
                Console.WriteLine("Выход за пределы указанного диапазона");
            
        }

        public void DecValue()
        {
            if (value-- > minValue)
                value = value--;
            else
                Console.WriteLine("Выход за пределы указанного диапазона");
        }
    }
}
