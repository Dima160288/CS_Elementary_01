using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /*Создать класс, содержащий динамический массив и количество элементов в нем. Добавить конструктор, который выделяет память под заданное
     * количество элементов, и деструктор. 
     * Добавить методы, позволяющие заполнять массив случайными числами, переставлять в данном массиве элементы в случайном порядке, 
     * находить количество различных элементов в массиве, выводить массив на экран.*/
    public class T6
    {
        private int[] array;
        public T6(int i)
        {
            array = new int[i];
        }
        public T6 (int[] arr, int i)
        {
            array = new int[arr.Length + i];
            for (int x = 0; x < arr.Length; x++)
            {
                array[x] = arr[x];
            }
        }
        ~T6()
        {
            Console.WriteLine("Bye bye");
        }
        public void FillingRandom()
        {
            Random r;
            for (int i = 0; i < array.Length; i++)
            {
                r = new Random();
                array[i] = r.Next();
            }
        }
        public void RandomSwap(int c)
        {
            Random a, b;
            for (int i = 0; i < c; i++)
            {
                a = new Random(); b = new Random();
                int x = a.Next(0, array.Length);
                int y = b.Next(0, array.Length);
                int buff = array[x];
                array[x] = array[y];
                array[y] = buff;
            }
        }
        public int Counter()
        {
            int count = array.Length;
            for (int i = 0; i< array.Length; i++)
                for (int j = 0; j< array.Length; j++)
                    if (array[i] == array[j])
                    {
                        count--;
                        break;
                    }
                        
            return count;    
        } 
        public void Show()
        {
            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}
