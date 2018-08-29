using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {

        struct Student
        {
            public string Name;
            public int GroupNumber;
            public int[] Exams;
            public double Middle;

            public Student(string name)
            {                
                Random rnd = new Random();

                Exams = new int[5];
                for (int i = 0; i < Exams.Length; i++)
                {
                    Exams[i] = rnd.Next(1, 6);
                    Thread.Sleep(15);
                }

                GroupNumber = rnd.Next(1, 9);

                this.Name = name;

                Middle = 0;
                for (int i = 0; i < Exams.Length; i++)
                {
                    Middle += Exams[i];
                }
                Middle /= Exams.Length;
            }
        }

        static void Main(string[] args)
        {

            Student[] students = new Student[10];
            students[0] = new Student("Dmitry M.");
            students[1] = new Student("Student m.K");
            students[2] = new Student("asdasdsa");
            students[3] = new Student("Asdfas");
            students[4] = new Student("Qwerty");
            students[5] = new Student("Formonk J.D");
            students[6] = new Student("Zyak");
            students[7] = new Student("Vul");
            students[8] = new Student("Kiki");
            students[9] = new Student("AMD");
            students.OrderByDescending(x => x.Middle).ToArray();
            
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].Name);
                Console.Write("; Group: " + students[i].GroupNumber + "; ");
                foreach (var n in students[i].Exams)
                {
                    Console.Write(n + ", ");
                }
                Console.WriteLine();
            }         
            
            void GoodStudent()
            {
                foreach (var i in students)
                {
                    if (i.Middle >= 4)
                    {
                        Console.WriteLine($"Student{i.Name}, from Group{i.GroupNumber} have high grades with {i.GroupNumber} Average ball.");
                    }
                }
            }
            GoodStudent();

            Console.ReadLine();
        }
    }
}