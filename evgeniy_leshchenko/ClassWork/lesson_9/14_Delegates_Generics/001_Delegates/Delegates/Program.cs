using System;

// Делегаты.

namespace Delegates
{
    // Класс, метод которого будет сообщен с делегатом.
    using System;

    public class Class1
    {
        public delegate void MyDelegate(int a, int b, int c, out double d);

        class Program
        {
            static void Main()
            {
                int summand1 = 10, summand2 = 6, summand3 = 5;
                double avg;

                MyDelegate myDelegate = delegate (int a, int b, int c, out double d) { d = (a + b + c) / 3; };

                myDelegate(summand1, summand2, summand3, out avg);

                Console.WriteLine("{0}", avg);


                Console.ReadKey();
            }
        }
    }

}
