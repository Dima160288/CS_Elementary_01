using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_student
{
    struct student
    {
        private string name;
        private int groupNum;
        private int[] marks;
        private double gpa;

        public string Name { get => name; }
        public int GroupNum { get => groupNum; }
        public int[] Marks { get => marks; }
        public double GPA { get => gpa; }

        public student(string name, int groupNum, int[] marks)
        {
            this.name = name;
            this.groupNum = groupNum;
            this.marks = marks;
            gpa = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                gpa += marks[i];
            }
            gpa /= marks.Length;
        }                    
    }
    
    class Program
    {
        static void ShowExcellentStudents(student[] students)
        {
            foreach (var item in students)
            {
                if (item.GPA >= 4.0)
                {
                    Console.WriteLine(item.Name + $" from group №{item.GroupNum} is excellent student");
                }
            }
        }

        static student[] SortByGPA(student[] students)
        {
            Console.WriteLine("Sorted by GPA:");

            return students.OrderByDescending(x => x.GPA).ToArray();
        }

        static void ShowArrStudents(student[] students)
        {
            foreach (var item in students)
            {
                string joinedMarks = string.Join(", ", item.Marks);
                Console.WriteLine($"Student {item.Name} from group №{item.GroupNum} has such marks as: {joinedMarks} and GPA of {item.GPA}");
            }
        }

        static student[] FillStudentsArr(student[] students)
        {
            Random rand = new Random();

            for (int i = 0; i < students.Length; i++)
            {
                string name;
                int groupNum;
                int[] marks;

                Console.WriteLine($"Student #{i + 1}:");
                Console.Write("Enter Name:");
                name = Console.ReadLine();
                Console.Write("Enter group number:");
                groupNum = Convert.ToInt32(Console.ReadLine());
                marks = new int[] { rand.Next(1, 6), rand.Next(1, 6), rand.Next(1, 6), rand.Next(1, 6), rand.Next(1, 6) };
                students[i] = new student(name, groupNum, marks);
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            return students;
        }

        static void Main(string[] args)
        {
            student[] students = new student[10];

            FillStudentsArr(students);
            ShowArrStudents(students);
            Console.WriteLine("--------------------------------------------------------------------------------");
            ShowExcellentStudents(students);
            Console.WriteLine("--------------------------------------------------------------------------------");
            ShowArrStudents(SortByGPA(students));
        }
    }
}
