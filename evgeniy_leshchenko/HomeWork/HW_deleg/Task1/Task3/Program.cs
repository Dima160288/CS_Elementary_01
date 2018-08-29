using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public delegate double MyDelegate();

        public delegate double ResDelegate(MyDelegate[] arr);

        static void Main(string[] args)
        {
            Random rand = new Random();

            MyDelegate[] DelegMass = new MyDelegate[5];

            for (int i = 0; i < DelegMass.Length; i++)
            {
                DelegMass[i] = delegate () { return rand.Next(100); };
            }



            // как теперь передать этот массив делегатов в анонимный метод в качестве аргумента?
            ResDelegate resDelegate = delegate (MyDelegate[] DelegMass1)
            {
                double sum;
                double val;
                sum = 0;
                foreach (MyDelegate dg in DelegMass)
                {
                    val = dg();
                    Console.WriteLine(" Значение элемента массива: {0} ", val);

                    sum = sum + val;
                }

                return sum / DelegMass1.Length; /*тут среднее посчитать в foreach*/

            };

            Console.WriteLine(" Среднее значение: " + Convert.ToString(resDelegate(DelegMass)));

            Console.ReadKey();
        }
    }
}
