using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibraryStudent
{
    public struct Student : IComparable
    {
        String fio;
        int numberGroup;
        int[] performance;

        public Student(string fio, int numberGroup, int[] perfomance)
        {
            this.fio = fio;
            this.numberGroup = numberGroup;
            this.performance = perfomance;
        }

        public static Student[] CreateArray() // метод создания массива студентов с рандомными оценками от 1 до 5
        {
            Random rnd = new Random();
            Student[] arr = new Student[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите ФИО  {0}-го студента: ", i + 1);
                arr[i] = new Student(Console.ReadLine(), 1, new int[] { rnd.Next(6), rnd.Next(6), rnd.Next(6), rnd.Next(6), rnd.Next(6) });
                Thread.Sleep(100);
            }
            return arr;
        }
        public static void Display(Student[] arr)  // вывод на экран массива
        {
            foreach (Student s in arr)
            {
                Console.WriteLine(s.ToString());
            }
        }
        public static void Display(Student[] arr, int perf) // перегружен, вывод на экран
        {
            bool flag = true;
            byte count = 0;
            foreach (Student s in arr)
            {
                string massPerf = "";
                flag = true;
                foreach (int p in s.performance)
                {
                    if (p < perf)
                        flag = false;
                    else
                        massPerf += "   " + Convert.ToString(p);
                }
                if (flag)
                {
                    Console.WriteLine("\n Студент имеющий оценки не ниже  {0}", perf);
                    Console.WriteLine(s.ToString());
                    Console.WriteLine("\n имеет оценки {0}", massPerf);
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("\n НЕТ СТУДЕНТОВ СО ВСЕМИ ОЦЕНКАМИ НЕ НИЖЕ {0}\n", perf);
        }

        int IComparable.CompareTo(object obj)
        {
            Student temp = (Student)obj;

            if (this.performance.Sum() > temp.performance.Sum())
                return 1;
            else
                return -1;
        } // compareTo

        public override string ToString()
        {
            string info;
            info = string.Format("Fio:{0} \t Number Group:{1} \t Средний балл успеваемости {2}", this.fio, this.numberGroup, (double)this.performance.Sum() / 5);
            return info;
        } // override ToString
    }
}
