using System;

public class Class1
{
    public delegate void MyDelegate(int a, int b, int c, out int d);

    class Program
    {
        static void Main()
        {
            int summand1 = 5, summand2 = 5, summand3 = 5;
            double avg;

            MyDelegate myDelegate = delegate ( int a,  int b,  int c, out int d) { avg = (a + b + c)/3; };

            myDelegate( summand1,  summand2,  summand3, out avg);

            Console.WriteLine("{0}", avg);

           
            Console.ReadKey();
        }
    }
}

//Создайте анонимный метод, который принимает в качестве параметров три
//    целочисленных аргумента и возвращает среднее арифметическое этих аргументов.
