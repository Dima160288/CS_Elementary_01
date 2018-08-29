using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBase
{
    class Student
    {
        public string fullname;
        public string groupnumber;
        int[] gradearray = new int[10];
        int studylvl;

        public Student(string studentname, string groupnumber, int grade)
        {
            fullname = studentname;
            this.groupnumber = groupnumber;
            studylvl = grade;

        }

        public void GetStudylvl()
        {
            Console.WriteLine("Введите оценки {0} из группы {1}", fullname, groupnumber);
            for (int i = 0; i < gradearray.Length; i++)
            {
                Console.WriteLine("Оценка {0}/{1}", i + 1, gradearray.Length);
                gradearray[i] = Convert.ToInt32(Console.ReadLine());
                studylvl += gradearray[i];
            }
            studylvl /= gradearray.Length;
        }

        public void GetInfo()
        {
            if (studylvl > 67)
            {
                Console.WriteLine("Имя: {0} \nГруппа: {1} \nСредний бал: {2}", fullname, groupnumber, studylvl);
            }
            else
            {
                Console.WriteLine("{0} не достиг проходного бала.", fullname, groupnumber, studylvl);
            }

        }
    }
}
