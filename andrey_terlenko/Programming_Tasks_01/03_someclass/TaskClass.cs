using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_someclass
{
    internal class TaskClass
    {
        private int a;
        private int b;

        public TaskClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public void Show()
        {
            Console.WriteLine($"1st variable: {a}\n2nd variable: {b}");
        }

        public void ChangeVariables(int new_a, int new_b)
        {
            a = new_a;
            b = new_b;
        }

        public int Add()
        {
            return a + b;
        }

        public int FindMax()
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {
                throw new Exception("Numbers are equal");
            }
        }
    }
}
