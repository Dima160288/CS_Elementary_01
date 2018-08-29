using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    //Создать класс с двумя переменными.Добавить функцию вывода на экран и функцию изменения этих 
    //переменных.Добавить функцию, которая находит 
    //сумму значений этих переменных, и функцию которая находит наибольшее 
    //значение из этих двух переменных. 
    class Program
    {
        static void Main(string[] args)
        {
            Variable variable = new Variable();
            int sw;
            bool q = true; ;
            do
            {
                variable.Info();
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1: { variable.Display();  } break;
                    case 2:  { variable.Change(); } break;
                    case 3: { variable.Sum(); } break;
                    case 4: { variable.Compasion(); } break;
                    case 5: { q = false; } break;

                }
               
            }
            while (q);
        }
    }

    class Variable
    {
        int first;
        int second;

        public void Compasion()
        {
            if (first > second)
                Console.WriteLine(" Число  {0} больше числа {1}", first, second);
            if (first < second)
                Console.WriteLine(" Число  {0} меньше числа {1}", first, second);
            else
                Console.WriteLine(" Число  {0} равно числу {1}", first, second);
        }

        public void Sum()
        {
            Console.WriteLine("Сумма переменных равна {0}", first + second);
        }

        public void Change()
        {
            Console.WriteLine("Введите значение первой переменной");
            this.first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второй переменной");
            this.second = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("First variable : {0} \n Second Variable : {1}", first, second);
        }

        public void Info()
        {
            Console.WriteLine("\t\t\t\tВыберите операцию из списка " + "\n\tВывести на экран  - 1" + "\n\t Изменить переменные  - 2" +
                "\n\tСумма значений переменных - 3" + "\n\t Сравнивание значений переменных - 4" + "\n \t Выход из программы - 5\n\n\n");

        }
    }
}
