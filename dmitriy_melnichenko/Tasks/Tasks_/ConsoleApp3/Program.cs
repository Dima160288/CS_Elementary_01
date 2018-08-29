using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SomeClass
    {
        private string a;
        private string b;
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }

        public SomeClass()
        {
            a = "Mamma Mia";
            b = "Hell Rider";            
        }
        public SomeClass(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine($"{a} , {b}");
        }
        ~SomeClass()
        {
            Console.WriteLine("Movies have been deleted");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass films = new SomeClass();
            films.Show();

            SomeClass newFilms = new SomeClass("Rogue One", "Final Destination");
            newFilms.Show();            

            Console.ReadLine();

        }
    }
}
