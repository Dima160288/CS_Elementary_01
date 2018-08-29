using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            UkrainianWords dictionary = new UkrainianWords();

            Console.WriteLine(dictionary["table"]);

            Console.ReadKey();
        }
    }
}
