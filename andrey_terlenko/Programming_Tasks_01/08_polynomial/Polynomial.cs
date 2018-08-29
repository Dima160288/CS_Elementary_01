using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_polynomial
{
    class Polynomial
    {
        private int[] variables;
        int power;

        public int[] Variables { get => variables; }
        public int Power { get => power; }

        public int this[int index]
        {
            get { return variables[index]; }
            set { variables[index] = value; }
        }

        public Polynomial(int[] variables)
        {
            this.variables = variables;
            this.power = variables.Length - 1;
        }

        public void Show()
        {
            int power = this.power;
            for (int i = 0; i < variables.Length; i++)
            {
                Console.Write($"{variables[i]}x^{power}");
                power--;
                if (i != variables.Length - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine();
        }

        public double CalculateForVal(double val)
        {
            int power = this.power;
            double result = 0;
            for (int i = 0; i < this.variables.Length; i++)
            {
                result += variables[i] * Math.Pow(val, power);
                power--;
            }
            return result;
        }

        //Meh, don't know how to do this shit

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            int resPower = Math.Max(p1.variables.Length, p2.variables.Length);
            int[] res = new int[resPower];
            for (int i = 0; i < resPower; i++)
            {
                int a = 0;
                int b = 0;
                if (i < p1.variables.Length)
                {
                    a = p1[i];
                }
                if (i < p2.variables.Length)
                {
                    b = p2[i];
                }
                res[i] = a + b;
            }
            return new Polynomial(res);
        }

        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            int resPower = Math.Max(p1.variables.Length, p2.variables.Length);
            int[] res = new int[resPower];
            for (int i = 0; i < resPower; i++)
            {
                int a = 0;
                int b = 0;
                if (i < p1.variables.Length)
                {
                    a = p1[i];
                }
                if (i < p2.variables.Length)
                {
                    b = p2[i];
                }
                res[i] = a - b;
            }
            return new Polynomial(res);
        }

        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            int[] res = new int[p1.variables.Length + p2.variables.Length - 1];
            for (int i = 0; i < p1.variables.Length; ++i)
                for (int j = 0; j < p2.variables.Length; ++j)
                    res[i + j] += p1[i] * p2[j];
            return new Polynomial(res);
        }
    }
}
