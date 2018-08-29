using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    /*Составить описание класса многочленов от одной переменной, задаваемых сте­пенью многочлена и массивом коэффициентов.
     * Предусмотреть методы для вы­числения значения многочлена для заданного аргумента,
     * операции сложения, вычитания и умножения многочленов с получением нового объекта-многочлена, вывод на экран описания многочлена.*/
    public class T8
    {

    }
    public class Polynomial
    {
        int[] index;
        int power;
        public Polynomial(int[] i)
        {
            index = i;
            power = i.Length -1;
        }
        public double ToCount(int x)
        {
            int pow = power;
            double result = 0;
            for (int i = 0; i < index.Length; i++)
            {
                result += index[i] * Math.Pow(x, power);
                pow--;
            }
            return result;
        }
        public void Show()
        {
            int pow = power;
            for (int i = 0; i < index.Length; i++)
            {
                Console.Write("{0}x^{1}", index[i], pow);
                pow--;
                if (pow >= 0)
                    Console.Write(" + ");
            }
        }
        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            int[] ind;
            int indMin;
            if (a.index.Length > b.index.Length)
            {
                ind = a.index;
                indMin = b.index.Length;
                for (int i = indMin - 1; i >= 0; i--)
                {
                    ind[i] = ind[i] + b.index[i];
                }
            }
            else
            {
                ind = b.index;
                indMin = a.index.Length;
                for (int i = indMin - 1; i >= 0; i--)
                {
                    ind[i] = ind[i] + a.index[i];
                }
            }
            return new Polynomial(ind);

        }
        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            int[] ind;
            int indMin;
            if (a.index.Length > b.index.Length)
            {
                ind = a.index;
                indMin = b.index.Length;
                for (int i = indMin - 1; i >= 0; i--)
                {
                    ind[i] = b.index[i]- ind[i];
                }
            }
            else
            {
                ind = b.index;
                indMin = a.index.Length;
                for (int i = indMin - 1; i >= 0; i--)
                {
                    ind[i] = ind[i] - a.index[i];
                }
            }
            return new Polynomial(ind);
        }
        
        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            int[] ind = new int[a.index.Length + b.index.Length - 1];
            for (int i = 0; i < a.index.Length; ++i)
                for (int j = 0; j < b.index.Length; ++j)
                    ind[i + j] += a.index[i] * b.index[j];
            return new Polynomial(ind);
        }
    }
}