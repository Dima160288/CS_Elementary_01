using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial test = new Polynomial(new int[] { 5, 6, 7, 8});
            test.Show();
            //Console.WriteLine(test.CalculateForVal(2));
            Polynomial qwerty = new Polynomial(new int[] { 8, 4, 1, 3, 7, 2 });
            qwerty.Show();

            Polynomial res_1 = test + qwerty;
            res_1.Show();

            res_1 = test - qwerty;
            res_1.Show();

            res_1 = test * qwerty;
            res_1.Show();
        }
    }
}
