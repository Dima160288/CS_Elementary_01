using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibraryStudent;

namespace Zadacha_MassStudent_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arr;
            ClassLibraryInfo.Interaction.InformationMethod();/// Info method
            arr = Student.CreateArray();  //create array
            Student.Display(arr); // display array
            Console.WriteLine("-----------------------------------------------------------------------");
            Array.Sort(arr); // sort array
            Console.WriteLine("Список студентов отсортирован по среднему баллу успеваемости");
            Student.Display(arr); // display after sort array
            Student.Display(arr, 2); // перегружений метод вывода списка студентов   
        }                               //с параметром сортировки - найменьшая оценка


       
    }

   
}
