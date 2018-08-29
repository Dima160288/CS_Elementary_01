using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Polymorphism
{
    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        // Замещение метода базового класса
        public void Method()
        {
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
