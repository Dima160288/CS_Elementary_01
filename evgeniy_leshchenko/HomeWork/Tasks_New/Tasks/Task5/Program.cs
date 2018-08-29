using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5.	Создать класс с двумя переменными.Добавить  конструктор
//    с входными параметрами.Добавить конструктор, инициализирующий члены 
//        класса по умолчанию.Добавить деструктор, выводящий на экран сообщение об удалении объекта.


namespace Task5
{
    class Program
    {
        // показывать тут вобщем то нечего
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();

            TestClass tc2 = new TestClass(1000,2000);

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
            firstNum = 10;
            secondNum = 100;
        }

        public TestClass(int firstNum, int secondNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
        }

        // деструктор(финалайзер)
        ~TestClass()
        {
            Console.WriteLine("Мне хана...");
        }

    }


}



