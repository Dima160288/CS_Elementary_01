using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{

    //1.	Создайте структуру с именем student, содержащую поля: фамилия и инициалы, номер группы, успеваемость 
    //    (массив из пяти элементов). Создать массив из десяти элементов такого типа, упорядочить
    //    записи по возрастанию среднего балла.Добавить возможность вывода фамилий и номеров групп студентов,
    //        имеющих оценки, равные только 4 или 5.
    struct Student : IComparable<Student>
    {

        //  class Route 
        public int CompareTo(Student s)
        {
            return this.Avg.CompareTo(s.Avg);
        }

        private string fio;
        private int groupID;
        private int[] arrMarks; // как его закрыть? можно ли свойством?
        private double avg;


        public string Fio
        {
            get { return fio; }
        }

        public double Avg
        {
            get
            {
                avg = 0;
                foreach (int mark in arrMarks)
                {
                    avg = avg + mark;
                };
                return avg / arrMarks.Length;
            }
        }

        public int GroupID
        {
            get { return groupID; }
        }

        public Student(string fio, int groupID, int[] marks )
        {
            this.fio = fio;
            this.groupID = groupID;
            this.arrMarks = marks;  // скопирует же?
            avg = 0;
        }

        public int[] ArrMarks
        {
            get { return arrMarks; }
        }

    }



    class Program
    {

        static void Main(string[] args)
        {
            Student[] arrStudents = new Student[10];
            Random rnd = new Random();

            FillArr(arrStudents);


            ShowArr(arrStudents);
            ShowGoodStudents(arrStudents);

            Console.WriteLine("\n\n\nSorted students by AVG marks: ");
            SortArr(arrStudents);
            ShowArr(arrStudents);

            Console.ReadKey();
        }

        private static void FillArr(Student[] arrSt)
        {

            Random rand = new Random();

            for (int i = 0; i < arrSt.Length; i++)
            {
                arrSt[i] = new Student("name" + i, rand.Next(1, 5), new int[5]
                {
                    rand.Next(3, 6),
                    rand.Next(3, 6),
                    rand.Next(3, 6),
                    rand.Next(3, 6),
                    rand.Next(3, 6)
                });
            }

        }

        private static void ShowGoodStudents(Student[]  arrSt)
        {
            
            Console.WriteLine("\n\n\nGood Students");

            foreach (Student std in arrSt)
            {
                bool badStudent = false;

                foreach (int mark in std.ArrMarks)
                {
                    if (mark < 4) badStudent = true;
                };

                if(badStudent==false)
                {
                    Console.WriteLine("FIO: " + std.Fio + " GroupID: " + Convert.ToString(std.GroupID));
                }

            }

        }

        private static void ShowArr(Student[] arrSt)
        {
            foreach (Student std in arrSt)
            {
                Console.WriteLine("FIO: " + std.Fio + " GroupID: " + Convert.ToString(std.GroupID) + " AVGmark: " + Convert.ToString(std.Avg));
                foreach (int mark in std.ArrMarks) { Console.WriteLine("Mark: " + Convert.ToString(mark)); };

            }
        }

        private static void SortArr(  Student[] arrSt)
        {
            Array.Sort(arrSt);
        }

    }
}
