//using Solver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Testing
{
    class Program
    {
        // 2
        //static double[] Solve(double a, double b, double c)
        //{
        //    var discriminant = b * b - 4 * a * c;
        //    var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        //    var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

        //    return new[] { x1, x2 };
        //}

        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            // 1
            var discriminant = b * b - 4 * a * c;

            var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);

            // 2
            //var result = Quadratic.Solve(a, b, c);
            //var result = Solve(a, b, c);

            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);

            Console.ReadLine();
        }
    }
}
