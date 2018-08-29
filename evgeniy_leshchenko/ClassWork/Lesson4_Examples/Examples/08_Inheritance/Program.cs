using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance
{
    class BaseClass
    {
        public int field1;
        public int field2;
        public int field3;
    }

    class DerivedClass : BaseClass
    {
        public int field4;
        public int field5;
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;

            instance.field4 = 4;
            instance.field5 = 5;

            // Upcast
            var newInstance = (BaseClass)instance;

            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            //Console.WriteLine(newInstance.field4);
            //Console.WriteLine(newInstance.field5);

            Console.WriteLine("instance ID: {0}", instance.GetHashCode());
            Console.WriteLine("newInstance ID: {0}", newInstance.GetHashCode());

            Console.ReadLine();

        }
    }
}
