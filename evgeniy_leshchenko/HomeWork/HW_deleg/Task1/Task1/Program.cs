using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate double MyDelegate(int a, int b, int c);

       
        
            static void Main()
            {
                int summand1 = 11, summand2 = 6, summand3 = 5;
                double avg;

                MyDelegate myDelegate = delegate (int a, int b, int c) { return (Convert.ToDouble(a) + (double)b + (double)c) / 3; };

                avg = myDelegate(summand1, summand2, summand3);

                Console.WriteLine("{0}", avg);


                Console.ReadKey();
            }
        
    }
}
