using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.	Создать класс с двумя переменными.Добавить функцию вывода на экран и функцию 
//    изменения этих переменных.Добавить функцию, которая находит сумму значений этих переменных, 
//        и функцию которая находит наибольшее значение из этих двух переменных.

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            TestClass cls = new TestClass(rand.Next(1,50), rand.Next(1,50));

            Console.WriteLine("Переменная 1: " + cls.FirstNum + "\nПеременная 2:" + cls.SecondNum);

            Console.WriteLine("\n\nВывод суммы двух переменных: " + cls.GetSumm());

            if(cls.FirstNum != cls.SecondNum)
                Console.WriteLine("\n\nВывод большей из двух переменных: " +  cls.GetMax());
            else
                Console.WriteLine("\n\nПеременные равны");

            Console.ReadKey();
        }
    }


   public class TestClass
    {
        private int firstNum;
        private int secondNum;


        public int FirstNum
        {
            get { return firstNum; }
        }

        public int SecondNum
        {
           get { return secondNum; }
        }

        public TestClass()
        {

        }

        public TestClass(int i, int y)
        {
            firstNum = i;
            secondNum = y;
        }

        public int GetSumm()
        {
            return FirstNum + SecondNum;
        }

        public int GetMax()
        {

            if (FirstNum > SecondNum)
                return FirstNum;
            else
                return SecondNum;
        }

    }

}
