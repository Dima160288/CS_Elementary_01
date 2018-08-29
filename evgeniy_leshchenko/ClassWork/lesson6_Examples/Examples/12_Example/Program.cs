using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();

            Console.WriteLine(p.getString_1());
            Console.WriteLine(((Child)p).getString_1());
            Console.WriteLine(p.getString_2());
            Console.WriteLine(((Child)p).getString_2());

            Console.ReadKey();
        }
    }
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("I'm Parent");
        }

        public String getString_1()
        {
            return "String_1 from Parent";
        }

        public virtual String getString_2()
        {
            return "String_2 from Parent virtual";
        }
    }
    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("I'm Child");
        }

        public String getString_1()
        {
            return "String_1 from Child";
        }

        public override String getString_2()
        {
            return "String_2 from Child";
        }
    }

}
