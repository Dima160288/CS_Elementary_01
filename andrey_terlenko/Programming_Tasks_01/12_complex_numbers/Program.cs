using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_complex_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber test = new ComplexNumber(-1, 3);
            test.Show();
            Console.WriteLine("---------------------------------------------");
            /*ComplexNumber qwerty = new ComplexNumber(1, 2);
            qwerty.Show();
            Console.WriteLine("---------------------------------------------");
            ComplexNumber res = test + qwerty;
            res.Show();
            Console.WriteLine("---------------------------------------------");
            res = test - qwerty;
            res.Show();
            Console.WriteLine("---------------------------------------------");
            res = test * qwerty;
            res.Show();
            Console.WriteLine("---------------------------------------------");
            res = test / qwerty;
            res.Show();
            Console.WriteLine("---------------------------------------------");
            res = ComplexNumber.Conjugate(test);
            res.Show();*/

            ComplexNumber res_1 = test.Exponentiation(3);
            res_1.Show();
        }
    }
}
