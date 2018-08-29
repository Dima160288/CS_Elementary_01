using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW005_1
{
    public static class Calc
    {
        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Myltiply(double a, double b)
        {
            return a * b;
        }

        public static double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

        public static double Square(double a)
        {
            return a * a;
        }
        public static double Power(double a, int b)
        {
            double res = a;
            for (int i = 0; i < b - 1; i++)
            {
                res = res * a;
            }
            return res;
        }
    }
}
