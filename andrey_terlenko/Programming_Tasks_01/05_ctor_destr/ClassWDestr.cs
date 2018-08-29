using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ctor_destr
{
    class ClassWDestr<T_1, T_2>
    {
        private T_1 a;
        private T_2 b;

        public ClassWDestr()
        {
            a = default(T_1); //присваивает соотв значение по умолчанию
            b = default(T_2);
        }

        public ClassWDestr(T_1 a, T_2 b)
        {
            this.a = a;
            this.b = b;
        }

        public void Show()
        {
            Console.WriteLine($"1st variable: {a}\n2nd variable: {b}");
        }

        ~ClassWDestr()
        {
            Console.WriteLine("Object of class ClassWDestr is disposed of");
        }
    }
}
