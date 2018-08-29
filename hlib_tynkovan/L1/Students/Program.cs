using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.    Определить класс с именем Student, содержащую следующие поля: фамилия и инициалы; номер группы; успеваемость – массив из 10 элементов.
//методы:
//ввод данных в массив из n элементов в типа Student;
//упорядочить по возрастанию номера в группе;
//вывод студентов и номеров групп для студентов, если средний балл студента больше 67.

namespace Students
{
    class Students
    {
        public char Name;
        public string Surname;
        public char FatherName;
        public int Number;
        public int[] Points = new int[10];
        public int MidPoint;

        public Students()
        {
            Random rand = new Random();
            string[] Namer = { "Иванов", "Сидоров", "Тарасенко", "Вырвидуб", "Мотузочка", "Могильный", "Штротман", "Градов", "Петров", "Ткаченко" };

            Surname = Namer[rand.Next(0, 10)];
            Name = Namer[rand.Next(0, 10)][0];
            FatherName = Namer[rand.Next(0, 10)][0];
            Number = rand.Next(1, 4);
            int y = 0;
            for (int x = 0; x < 10; x++)
            {

                Points[x] = rand.Next(1, 100);
                y = y + Points[x];
            }
            MidPoint = y / 10;
        }

        public void ByNumber()
        {
            for (int x = 0; x < 10; x++)
            {
                if (this.Number == 1)
                {
                    Console.WriteLine("Ученики группы 1:");
                    Console.WriteLine(this.Surname + this.FatherName + this.Name);
                    Console.WriteLine(this.MidPoint);
                }
            }
            for (int x = 0; x < 10; x++)
            {
                if (this.Number == 2)
                {
                    Console.WriteLine("Ученики группы 2:");
                    Console.WriteLine(this.Surname + this.FatherName + this.Name);
                    Console.WriteLine(this.MidPoint);
                }
            }
            for (int x = 0; x < 10; x++)
            {

                if (this.Number == 3)
                {
                    Console.WriteLine("Ученики группы 3:");
                    Console.WriteLine(this.Surname + this.FatherName + this.Name);
                    Console.WriteLine(this.MidPoint);
                }
            }

        }

        public void ByPoints()
        {
            if (this.MidPoint > 67)
            {
                Console.WriteLine(this.Surname + this.FatherName + this.Name);
                Console.WriteLine(this.MidPoint);
                Console.WriteLine(this.Number);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Students[] Student = new Students[10];
            for (int i = 0; i < 10; i++)
            {
                Student[i] = new Students();
            }
            Console.WriteLine("Нажмите 1 что бы показать студентов по группам,нажмите 2 чтобы покахать студентов чей бал выше 67");
            int u = int.Parse(Console.ReadLine());
            if (u == 1)
            {
                for (int h = 0; h < 10; h++)
                {

                    Student[h].ByNumber();
                }
                Console.ReadLine();
            }
            if (u == 2)
            {
                for (int h = 0; h < 10; h++)
                {
                    Student[h].ByPoints();
                }
                Console.ReadLine();
            }
        }

    }
}
