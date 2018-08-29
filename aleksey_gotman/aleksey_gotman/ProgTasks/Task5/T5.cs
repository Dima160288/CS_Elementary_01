using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*Создать класс с двумя переменными. Добавить конструктор с входными параметрами. Добавить конструктор, инициализирующий члены класса по умолчанию. Добавить деструктор, выводящий на экран сообщение об удалении объекта.*/
    public class T5<T,V>
    {
        private T a;
        private V b;
        public T5()
        {
            a = default(T);
            b = default(V);
        }
        public T5 (T a, V b)
        {
            this.a = a;
            this.b = b;
        }
        ~T5()
        {
            Console.WriteLine("Bye bye");
        }
    }
}
