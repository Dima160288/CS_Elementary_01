using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass myClass1 = new MyClass(12, 32);
        }
    }

    class MyClass
    {
        int x;
        int y;

        public MyClass() { }

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        ~ MyClass()
        {
            Console.WriteLine("Отработал деструктор");
        }
    }
}
