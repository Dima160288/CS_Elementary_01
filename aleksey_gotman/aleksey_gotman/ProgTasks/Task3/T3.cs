using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Создать класс с двумя переменными. Добавить функцию вывода на экран и функцию изменения этих переменных. Добавить функцию, которая находит сумму значений этих переменных, и функцию которая находит наибольшее значение из этих двух переменных*/
    public class T3
    {
        private int a;
        private int b;
        public T3 (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Change(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine("a - {0}", a);
            Console.WriteLine("b - {0}", b);
        }
        public int Add()
        {
            return a + b;
        }
        public int Max()
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}
