using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    interface IEatSleep
    {
        void Eat();
        void Sleep();
    }

    interface IGuard
    {
        void Guard();
    }

    class Dog : IEatSleep, IGuard
    {
        public void Eat() { }
        public void Sleep() { }

        public void Guard() { }

    }

    class Cat : IEatSleep
    {
        public void Eat() { }
        public void Sleep() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Sleep();

            Cat cat = new Cat();
            cat.Eat();
            cat.Sleep();

            Console.ReadLine();

        }
    }
}
