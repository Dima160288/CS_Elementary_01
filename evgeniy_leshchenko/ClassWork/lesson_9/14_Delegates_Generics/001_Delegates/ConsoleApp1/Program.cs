using System;

// Делегаты.

namespace Delegates
{
    // Класс, метод которого будет сообщен с делегатом.
    using System;

    public class Class1
    {
        public delegate double MyDelegate(int a, int b, int c);

        class Program
        {
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

}
