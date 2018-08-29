using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Для комбинирования виртуальных и не виртуальных методов
namespace _10_Polymorphism
{
    class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        // Переопределение метода базового класса
        public override void Method()
        {
            //base.Method();

            Console.WriteLine("Method from DerivedClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // Upcast
            BaseClass instanceUp = instance;
            instanceUp.Method();

            // DownCast
            DerivedClass instanceDown = (DerivedClass)instanceUp;
            instanceDown.Method();

            Console.ReadLine();
        }
    }
}
