using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_someclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            TaskClass test = new TaskClass(a, b);
            test.Show();
            test.ChangeVariables(15, 25);
            test.Show();
            Console.WriteLine($"a + b = {test.Add()}");
            try
            {
                Console.WriteLine($"Number {test.FindMax()} is greater");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
