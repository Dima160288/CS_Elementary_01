using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance
{
    class BaseClass
    {
        public int baseNumber;

        public BaseClass()
        {

        }

        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }

    class DerivedClass : BaseClass
    {
        public int derivedNumber;

        //public DerivedClass()
        //{

        //}

        // Пользовательский конструктор.
        // При создании объекта производного класса, конструктор производного класса 
        // автоматически вызывает конструктор по умолчанию из базового класса.
        // Конструктор базового класса, присвоит всем данным какие-то свои безопасные значения.
        // После этого начнет работу конструктор производного класса, который повторно
        // будет определять значения для унаследованых членов. (ДВОЙНАЯ РАБОТА)!
        public DerivedClass(int number1, int number2)
            : base(number1)
        {
            //baseNumber = number1;

            derivedNumber = number2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedNumber);

            Console.ReadLine();
        }
    }
}
