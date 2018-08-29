using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Student
{
    class Program
    {
        const int STUDENTS_QUANTITY = 3;
        const int SUBJECT_QUANTITY = 2;

        static void Main(string[] args)
        {
            Student[] Results = new Student[STUDENTS_QUANTITY];

            GetStudents(Results);
            CheckGoodMark(Results);

            Console.ReadKey();
        }



        static void GetStudents(Student[] Students)
        {
            string buf;

            int[] Marks = new int[SUBJECT_QUANTITY];

            for (int i = 0; i < STUDENTS_QUANTITY; i++)
            {
                Console.WriteLine("Введите фамилию студента:");
                string Surname = Console.ReadLine();
                Console.WriteLine("Введитe инициалы студента:");
                string Initials = Console.ReadLine();
                Console.WriteLine("Введите группу студента:");
                buf = Console.ReadLine();
                int GroupNumber = Convert.ToInt32(buf);
                Console.WriteLine("Введите оценку студента: ");
                Student student = new Student(Surname, Initials, GroupNumber, Marks);
                for (int h = 0; h < SUBJECT_QUANTITY; h++)
                {
                    buf = Console.ReadLine();
                    student.marks[h] = Convert.ToInt32(buf);
                }
                Students[i] = student;
            }

            //сортировка
            for (int h = STUDENTS_QUANTITY - 1; h > 0; h--)
            {
                for (int s = 0; s < h; s++)
                {
                    if (Students[s].groupNumber > Students[s + 1].groupNumber)
                    {
                        int tmp1 = Students[s].groupNumber;
                        string tmp2 = Students[s].surname;
                        string tmp3 = Students[s].initials;
                        int[] tmp4 = Students[s].marks;

                        Students[s].groupNumber = Students[s + 1].groupNumber;
                        Students[s].surname = Students[s + 1].surname;
                        Students[s].initials = Students[s + 1].initials;
                        Students[s].marks = Students[s + 1].marks;

                        Students[s + 1].groupNumber = tmp1;
                        Students[s + 1].surname = tmp2;
                        Students[s + 1].initials = tmp3;
                        Students[s + 1].marks = tmp4;
                    }
                }
            }
        }

        static void CheckGoodMark(Student[] Students)
        {
            bool found = false;
            int summa = 0;
            float aver = 0;

            for (int i = 0; i < STUDENTS_QUANTITY; i++)
            {
                for (int j = 0; j < SUBJECT_QUANTITY; j++)
                    summa += Students[i].marks[j];

                aver = summa / SUBJECT_QUANTITY;

                if (aver >= 4.0)
                {
                    found = true;
                    Console.Write("Студент " + Students[i].surname + " " + Students[i].initials);
                    Console.Write(" из группы N" + Students[i].groupNumber);
                    Console.WriteLine(" имеет средний бал больше 4,0");
                }
                //aver = 0;
                //summa = 0;
            }
            if (!found)
            {
                Console.WriteLine("записей не найдено");
            }
        }

    }

    public struct Student
    {
        string surname;
        string initials;
        int groupNumber;
        int[] marks;
        //public string Surname { get; set; }
        //public string Initials { get { return initials; } }
        //public int GroupNumber { get { return groupNumber; } }
        //public int[] Marks { get { return marks; } }

        public Student(string surname, string initials, int groupNumber, int[] marks)
        {
            this.surname = surname;
            this.initials = initials;
            this.groupNumber = groupNumber;
            this.marks = marks;
        }

    }

}
