using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_
{
    class NewClass
    {
        private int a;
        private int b;

        public int B { get => b; set => b = value; }
        public int A { get => a; set => a = value; }

        public NewClass (int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void ShowConsole()
        {
            Console.WriteLine($"a ={a}, b={b}");
        }

        public int Summ ()
        {
            return a + b;
        }

        public int Max()
        {
            if (a > b) { return a; }
            else { return b; }
        }

        public void ChangeNumbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NewClass numbers = new NewClass(10, 20);            
            numbers.ShowConsole();
            numbers.ChangeNumbers(50, 100);
            numbers.ShowConsole();
            numbers.Summ();
            numbers.Max();

            Console.ReadLine();
        }
    }
}
