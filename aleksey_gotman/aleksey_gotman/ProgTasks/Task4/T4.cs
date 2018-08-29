using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Описать класс, реализующий десятичный счетчик, который может увеличивать или уменьшать свое значение на единицу в заданном диапазоне.
     * Предусмотреть инициализацию счетчика значениями по умолчанию и произвольными значениями.
     * Счетчик имеет два метода: увеличения и уменьшения, — и свойство, позволяющее получить его текущее состояние. 
     * Написать программу, демонстрирующую все возможности класса.*/
    public class T4
    {
        int start;
        int stop;
        private int count;
        public T4(int i, int start, int stop)
        {
            count = i;
            this.start = start;
            this.stop = stop;
        }
        public void TickUp()
        {
            if (count + 1 > stop)
                Stop();
            else
                count++;
        }
        public void TickOut()
        {
            if (count - 1 < start)
                Stop();
            else
                count--;
        }
        public int TickNow()
        {
            return count;
        }
        private void Stop()
        {
            Console.WriteLine("Out of Range");
        }
    }
}
